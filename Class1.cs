private FilterInfoCollection filter;
private VideoCaptureDevice device;
private List<Subject> subjects;
private Student currentStudent;
private Home home;
private StudentBUS stbus = new StudentBUS();
private SubjectBUS sjbus = new SubjectBUS();
private EigenFaceRecognizer eigenFaceRecognizer;
private bool IsTrained = false;
static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\Administrator\Downloads\QuanLySinhVien\QuanLySinhVien\BUS\haarcascade_frontalface_default.xml");

private bool isRecognize = false;

public bool IsRecognize
{
    get { return isRecognize; }
    set
    {
        isRecognize = value;
        PesentBtn.Enabled = isRecognize;
    }
}
private bool isCapturing = false;
private bool IsCapturing
{
    get { return isCapturing; }
    set
    {
        isCapturing = value;
    }
}
public Pesentation()
{
    InitializeComponent();
    IsRecognize = false;
    GetAllSubject();
    if (Login.account.RoleID == 2)
    {
        GetCurrentStudent();
    }
    else
    {
        MessageBox.Show("You are not a student, you have nothing to do here ok!");
        if (home == null)
        {
            home = new Home();
        }
        home.ShowDialog();
        this.Hide();
    }
}
public Pesentation(string PersonId, int role, Home home)
{
    InitializeComponent();
    IsRecognize = false;
    this.home = home;
    GetAllSubject();
    if (role == 2)
    {
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
    studentNameField.Enabled = false;
    studentIDField.Enabled = false;
}
private bool Present()
{
    string subjectSelected = (string)subjectSelects.SelectedItem;
    if (subjectSelected == null)
    {
        return false;
    }
    string studentName = studentNameField.Text;
    string studentID = studentIDField.Text;
    return true;
}

private void Pesentation_Load(object sender, EventArgs e)
{
    filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
    foreach (FilterInfo device in filter)
        cboDevice.Items.Add(device.Name);
    cboDevice.SelectedIndex = 0;
    device = new VideoCaptureDevice();
}
private void Pesentation_Close(object sender, FormClosingEventArgs e)
{
    if (device.IsRunning)
        device.Stop();
}

private void btnDetect_Click(object sender, EventArgs e)
{
    device = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
    device.NewFrame += Device_NewFrame;
    device.Start();
}
private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
{
    Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
    Image<Gray, byte> grayImage = bitmap.ToImage<Gray, byte>();
    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
    foreach (Rectangle rectangle in rectangles)
    {
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {

            using (Pen pen = new Pen(Color.Red, 1))
            {
                graphics.DrawRectangle(pen, rectangle);
            }
        }
        if (eigenFaceRecognizer != null && IsTrained)
        {
            CvInvoke.EqualizeHist(grayImage, grayImage);
            var result = eigenFaceRecognizer.Predict(grayImage);
            int crrStudentId = Convert.ToInt32(currentStudent.studentId);
            if (IsCapturing)
            {
                for (int i = 0; i < 5; i++)
                {
                    string pathImage = currentStudent.studentId + "-" + i + ".jpg";
                    imagePrev.Image.Save(pathImage);
                }
            }
            if (result.Label > 0 && result.Distance < 5000 && result.Label == crrStudentId)
            {
                MessageBox.Show("Okey! now you can pesent yourself");
                IsRecognize = true;
                device.Stop();
            }
            else
            {
                IsRecognize = false;
            }

        }
    }
    imagePrev.Image = bitmap;
}
private void StartCapture5TimesAndSave()
{
    IsTrained = false;
    for (int i = 0; i < 5; i++)
    {
        string pathImage = currentStudent.studentId + "-" + i + ".jpg";
        imagePrev.Image.Save(pathImage);
    }
}
private void TrainFace()
{
    int thresHold = 7000;
    List<Mat> images = new List<Mat>();
    int[] names = new int[5];
    try
    {
        for (int i = 0; i < 5; i++)
        {
            string pathImage = currentStudent.studentId + "-" + i + ".jpg";
            Mat image = CvInvoke.Imread(pathImage, Emgu.CV.CvEnum.ImreadModes.Grayscale);
            images.Add(image);
            names[i] = i;
        }
        if (eigenFaceRecognizer == null)
        {
            eigenFaceRecognizer = new EigenFaceRecognizer(5, thresHold);
        }
        eigenFaceRecognizer.Train(new VectorOfMat(images.ToArray()), new VectorOfInt(names));
        IsTrained = true;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
        IsTrained = false;
    }
}
private void CaptureBtn_Click(object sender, EventArgs e)
{
    StartCapture5TimesAndSave();
}

private void TrainAIBtn_Click(object sender, EventArgs e)
{
    TrainFace();
}