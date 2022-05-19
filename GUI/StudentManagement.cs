using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class StudentManagement : Form
    {
        private StudentBUS studentBUS = new StudentBUS();
        Home homeView;
        HandleStudent handleStudent;
        //private DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
        public StudentManagement()
        {
            if (Login.account.RoleID == 2)
            {
                MessageBox.Show("cut");
                this.Hide();
                if (homeView == null)
                {
                    homeView = new Home();
                }
                homeView.ShowDialog();
            }
            else
            {
                InitializeComponent();
            }
            //dgvcCheckBox.HeaderText = "Select";
            //studentsGridView.Columns.Add(dgvcCheckBox);
        }
        public StudentManagement(Home home)
        {
            this.homeView = home;
            if (Login.account.RoleID == 2)
            {
                MessageBox.Show("cut");
                this.Hide();
                if (homeView == null)
                {
                    homeView = new Home();
                }
                homeView.Show();
            }
            else
            {
                InitializeComponent();
            }
            //studentsGridView.Columns.Add(dgvcCheckBox);
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            studentsGridView.DataSource = studentBUS.GetAllStudentInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HandleStudent stView = new HandleStudent(this);
            stView.ShowDialog();
        }

        private void studentsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                
                Student studentSelected = GetStudentData(rowIndex);
                this.Hide();
                if (handleStudent == null)
                {
                    handleStudent = new HandleStudent(studentSelected,this);
                }
                handleStudent.ShowDialog();
            }
        }
        private Student GetStudentData(int rowIndex)
        {
            Student student = new Student();
            DataGridViewRow row = studentsGridView.Rows[rowIndex];
            student.classId = Convert.ToString(row.Cells["StudentId"].Value);
            student.dateOfBirth = Convert.ToString(row.Cells["DateOfBirth"].Value);
            student.studentName = Convert.ToString(row.Cells["StudentName"].Value);
            student.gender = Convert.ToInt32(row.Cells["Gender"].Value);
            student.studentId = Convert.ToString(row.Cells["StudentId"].Value);
            return student;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (homeView == null)
            {
                homeView = new Home();
            }
            this.Dispose();
            homeView.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            Student student = new Student();
            MessageBox.Show(student.studentId);
            
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            HandleSearchBoxChange();
        }

        private void HandleSearchBoxChange()
        {
            string searchKey =  searchBox.Text.Trim();
            List<Student> students = studentBUS.GetStudentsByString(searchKey);
            studentsGridView.DataSource = students;
        }
    }
}
