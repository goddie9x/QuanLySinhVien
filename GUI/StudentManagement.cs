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
        StudentInfo handleStudent;
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentInfo stView = new StudentInfo();
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
                    handleStudent = new StudentInfo(studentSelected);
                }
                handleStudent.ShowDialog();
            }
        }
        private Student GetStudentData(int rowIndex)
        {
            Student student = new Student();
            DataGridViewRow row = StudentsGridView.Rows[rowIndex];
            student.classId = Convert.ToString(row.Cells["StudentId"].Value);
            student.dateOfBirth = Convert.ToString(row.Cells["DateOfBirth"].Value);
            student.studentName = Convert.ToString(row.Cells["StudentName"].Value);
            student.gender = Convert.ToInt32(row.Cells["Gender"].Value);
            student.studentId = Convert.ToString(row.Cells["StudentId"].Value);
            return student;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                Home.instance.ShowDialog();
            }
            catch (Exception ex)
            {
                Home.instance = new Home();
                Home.instance.ShowDialog();
            }
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
            string searchKey = searchBox.Text.Trim();
            List<Student> students = studentBUS.GetStudentsByString(searchKey);
            StudentsGridView.DataSource = students;
        }

        private void StudentManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StudentManagement_Shown(object sender, EventArgs e)
        {
            if (Login.account.RoleID == 2)
            {
                MessageBox.Show("You have no permision!");
                Home.instance.Show();
                this.Hide();
            }
            else
            {
                StudentsGridView.DataSource = studentBUS.GetAllStudentInfo();
            }
        }
    }
}