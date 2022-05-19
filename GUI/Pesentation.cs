using BUS;
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System;
using Emgu.CV;
using System.Drawing;
using Emgu.CV.Structure;
using AForge.Video;
using Emgu.CV.Face;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Linq;
using System.Diagnostics;

namespace GUI
{
    public partial class Pesentation : Form
    {
        #region Variables
        int testid = 0;
        private VideoCaptureDevice videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\Administrator\Downloads\QuanLySinhVien\QuanLySinhVien\BUS\haarcascade_frontalface_default.xml");
        Image<Bgr, Byte> faceResult = null;
        List<Mat> TrainedFaces = new List<Mat>();
        List<int> PersonsLabes = new List<int>();
        private FilterInfoCollection filter;
        private VideoCaptureDevice device;
        private List<Subject> subjects;
        private Student currentStudent;
        private Home home;
        private StudentBUS stbus = new StudentBUS();
        private SubjectBUS sjbus = new SubjectBUS();
        private EigenFaceRecognizer eigenFaceRecognizer;

        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();

        #endregion

        public Pesentation(Home home = null)
        {
            InitializeComponent();
            GetAllSubject();
            if (Login.account.RoleID== 2)
            {
                studentNameField.Enabled = false;
                studentIDField.Enabled = false;
                GetCurrentStudent();
            }
            else
            {
                MessageBox.Show("You are not a student, you have nothing to do here ok!");
                if (home == null)
                {
                    home = new Home();
                }
                this.Dispose();
                home.ShowDialog();
            }
        }
        private void GetAllSubject()
        {
            subjects = sjbus.GetAllSubject();
            if (subjects != null)
            {
                foreach (Subject item in subjects)
                {
                    subjectSelects.Items.Add(item.subjectName);
                }
            }
        }
        private void GetCurrentStudent()
        {
            currentStudent = stbus.GetStudentInfoById(Login.account.sUsername);
            studentNameField.Text = currentStudent.studentName;
            studentIDField.Text = currentStudent.studentId;
        }

        private void Pesentation_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                cboDevice.Items.Add(device.Name);
            cboDevice.SelectedIndex = 0;
        }
        private void Pesentation_Close(object sender, FormClosingEventArgs e)
        {
            if (videoCapture.IsRunning)
            {
                videoCapture.Stop();
            }
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            //Dispose of Capture if it was created before
            if (videoCapture != null) videoCapture.Stop();
            videoCapture = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            videoCapture.Start();
            //videoCapture.ImageGrabbed += ProcessFramet
            videoCapture.NewFrame += ProcessFrame;
            // videoCapture.Start();
            btnDetectFaces.Enabled = true;
        }

        private void ProcessFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Step 1: Video Capture
            if (videoCapture != null && videoCapture.IsRunning)
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                Image<Bgr, byte> currentImage = bitmap.ToImage<Bgr, byte>();
                frame = currentImage.Mat;
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(imagePrev.Width, imagePrev.Height, Inter.Cubic);

                //Step 2: Face Detection
                if (facesDetectionEnabled)
                {
                    //Convert from Bgr to Gray Image
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    //Enhance the image to get better result
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                    //If faces detected
                    if (faces.Length > 0)
                    {

                        foreach (var face in faces)
                        {
                            //Draw square around each face 
                            // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                            //Step 3: Add Person 
                            //Assign the face to the picture Box face picDetected
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picDetected.SizeMode = PictureBoxSizeMode.Zoom;
                            picDetected.Image = resultImage.AsBitmap<Bgr,Byte>();

                            if (EnableSaveImage)
                            {
                                //We will create a directory if does not exists!
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                                //we will save 10 images with delay a second for each image 
                                //to avoid hang GUI we will create a new task
                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        try
                                        {
                                            //resize the image then saving it
                                            resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + currentStudent.studentId +"-"+i+".jpg");
                                            Thread.Sleep(1000);
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show(e.ToString());
                                        }
                                    }
                                });

                            }
                            EnableSaveImage = false;

                            if (btnAddPerson.InvokeRequired)
                            {
                                btnAddPerson.Invoke(new ThreadStart(delegate {
                                    btnAddPerson.Enabled = true;
                                }));
                            }

                            // Step 5: Recognize the face 
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                picDetected.Image = grayFaceResult.AsBitmap<Gray, Byte>();
                                //Here results found known faces
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    string studentIdDetected = PersonsNames[result.Label];
                                    picturePreviewMin.Image = TrainedFaces[result.Label].ToBitmap();
                                    CvInvoke.PutText(currentFrame, studentIdDetected, new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                    if (studentIdDetected == Login.account.sUsername)
                                    {
                                        if (PesentBtn.InvokeRequired)
                                        {
                                            PesentBtn.Invoke(new ThreadStart(delegate {
                                                PesentBtn.Enabled = true;
                                            }));
                                        }
                                        else
                                        {
                                            PesentBtn.Enabled = true;
                                        }
                                    }
                                    else{
                                        if (PesentBtn.InvokeRequired)
                                        {
                                            PesentBtn.Invoke(new ThreadStart(delegate {
                                                PesentBtn.Enabled = false;
                                            }));
                                        }
                                        else
                                        {
                                            PesentBtn.Enabled = false;
                                        }
                                    }
                                }
                                //here results did not found any know faces
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                                    if (PesentBtn.InvokeRequired)
                                    {
                                        PesentBtn.Invoke(new ThreadStart(delegate {
                                            PesentBtn.Enabled = false;
                                        }));
                                    }
                                    else
                                    {
                                        PesentBtn.Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                }

                //Render the video capture into the Picture Box imagePrev
                imagePrev.Image = currentFrame.AsBitmap<Bgr, Byte>();
            }

            //Dispose the Current Frame after processing it to reduce the memory consumption.
            if (currentFrame != null)
                currentFrame.Dispose();
        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
            btnAddPerson.Enabled = true;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            btnAddPerson.Enabled = false;
            EnableSaveImage = true;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }
        //Step 4: train Images .. we will use the saved images from the previous example 
        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage.Mat);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('-')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);
                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(new VectorOfMat(TrainedFaces.ToArray()), new VectorOfInt(PersonsLabes.ToArray()));

                    isTrained = true;
                    //Debug.WriteLine(ImagesCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }
        private bool Present()
        {
            string subjectSelected = (string)subjectSelects.SelectedItem;
            if (subjectSelected == null)
            {
                MessageBox.Show("Please select which subject do you want to present!");
                return false;
            }
            return stbus.HandlePresentation(Login.account.sUsername,subjectSelected);
        }

        private void PesentBtn_Click(object sender, EventArgs e)
        {
            if (Present())
            {
                MessageBox.Show("Present successfull");
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again");
            }
        }
    }        
}
