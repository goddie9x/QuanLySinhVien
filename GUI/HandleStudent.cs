using System.Windows.Forms;
using DTO;
using System;
using System.Linq;
using BUS;

namespace GUI
{
    public partial class HandleStudent : Form
    {
        private Student currentStudent;
        private StudentManagement studentManagement;
        public HandleStudent()
        {
            InitializeComponent();
            txtStudentId.Enabled = true;
        }
        public HandleStudent(StudentManagement studentManagement)
        {
            InitializeComponent();
            txtStudentId.Enabled = true;
            this.studentManagement = studentManagement;
        }
        public HandleStudent(Student studentData)
        {
            InitializeComponent();
            this.currentStudent = studentData;
            txtStudentId.Enabled = false;
            InitStudentData();
        }
        public HandleStudent(Student studentData, StudentManagement studentManagement)
        {
            InitializeComponent();
            this.currentStudent = studentData;
            txtStudentId.Enabled = false;
            InitStudentData();
            this.studentManagement = studentManagement;
        }
        public void InitStudentData()
        {
            if(currentStudent!= null)
            {
                txtStudentId.Text = currentStudent.studentId;
                txtClassId.Text = currentStudent.classId;
                txtStudentName.Text = currentStudent.studentName;
                dateOfBirth.Value = Convert.ToDateTime(currentStudent.dateOfBirth);
                SetGender(currentStudent.gender);
            }
        }
        public void SetGender(int genderCode)
        {
            switch (genderCode)
            {
                case 0:
                    {
                        radioMale.Checked = true;
                        break;
                    }
                case 1:
                    {
                        radioFemale.Checked = true;
                        break;
                    }
                case 2:
                    {
                        radioOther.Checked = true;
                        break;
                    }
            }
        }
        public int GetGender()
        {
            //Linq
            var checkedButton = groupBoxMain.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            switch (checkedButton.Text) 
            {
                case "Male": return 0;
                case "Female": return 1;
                case "Other": return 2;
            }
            return 0;
        }

        private Student GetStudentData()
        {
            Student student = new Student();

            student.studentId = txtStudentId.Text;
            student.classId = txtClassId.Text;
            student.studentName = txtStudentName.Text;
            student.dateOfBirth = dateOfBirth.Value.ToString();
            student.gender = GetGender();

            return student;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Student studentInfo = GetStudentData();
            StudentBUS studentBUS = new StudentBUS();
            if (currentStudent == null)
            {
                if (!studentBUS.AddStudent(studentInfo)) 
                {
                    MessageBox.Show("Create student false");
                }
                else
                {
                    MessageBox.Show("Create student success");
                    this.Dispose();
                    if (studentManagement == null)
                    {
                        studentManagement = new StudentManagement();
                    }
                    studentManagement.Show();
                }
            }
            else
            {
                if (!studentBUS.UpdateStudentInfo(studentInfo))
                {
                    MessageBox.Show("Update student false");
                }
                else
                {
                    MessageBox.Show("Update student success");
                    this.Hide();
                    StudentManagement studentManagement = new StudentManagement();
                    studentManagement.Show();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student studentInfo = GetStudentData();
            StudentBUS studentBUS = new StudentBUS();
            if (currentStudent == null)
            {
                    MessageBox.Show("Delete student failed");
            }
            else
            {
                if (studentBUS.DeleteStudent(studentInfo))
                {
                    MessageBox.Show("Delete student success");
                    this.Hide();
                    StudentManagement studentManagement = new StudentManagement();
                    studentManagement.Show();
                }
                else
                {
                    MessageBox.Show("Delete student failed");
                }
            }
        }

        private void BackToManagerment()
        {
            StudentManagement studentManagement = new StudentManagement();
            this.Dispose();
            studentManagement.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToManagerment();
        }

        
    }
}
