using System.Data.SqlClient;
using System.Data;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DAL
{
    public static class SqlConnectionData
    {
        //create the string connection
        //đây là ADO đây này
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-CNOUC2I;Initial Catalog=StudentManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static bool GetUserInfo(ref Account account)
        {
            //function connect to db
            //đây là ADO đây này
            SqlConnection conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("proc_login", conn);
            conn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", account.sUsername);
            command.Parameters.AddWithValue("@pass", account.sPassword);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                account.sAccountID = reader["sAccountID"].ToString();
                account.RoleID = Int32.Parse(reader["RoleID"].ToString());
                reader.Close();
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DataTable GetAllStudentsDataTable()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Student ", conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            SqlConnection conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("SELECT * FROM Student ", conn);
            conn.Open();
            SqlDataReader oReader = command.ExecuteReader();
            while (oReader.Read())
            {
                Student student = new Student();

                student.classId = oReader["ClassId"].ToString();
                student.dateOfBirth = oReader["DateOfBirth"].ToString();
                student.studentName = oReader["StudentName"].ToString();
                student.studentId = oReader["StudentId"].ToString();
                student.gender = Convert.ToInt32(oReader["Gender"].ToString());
                students.Add(student);
            }
            conn.Close();
            return students;
        }
        public static List<Student> GetStudentsByString(string queryText)
        {
            List<Student> students = new List<Student>();
            SqlConnection conn = SqlConnectionData.Connect();
            string query;
            if(queryText == "")
            {
                query = "SELECT * FROM Student";
            }
            else
            {
                query = "SELECT * FROM Student inner join dbo.Class on Student.ClassId = Class.ClassId"
                + " where CHARINDEX(@queryText, Student.StudentName) > 0 "
                + " or CHARINDEX(@queryText, Class.ClassName) > 0 or CHARINDEX(@queryText, Student.StudentId) > 0";
            }
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@queryText", queryText);
            conn.Open();
            SqlDataReader oReader = command.ExecuteReader();
            while (oReader.Read())
            {
                Student student = new Student();

                student.classId = oReader["ClassId"].ToString();
                student.dateOfBirth = oReader["DateOfBirth"].ToString();
                student.studentName = oReader["StudentName"].ToString();
                student.studentId = oReader["StudentId"].ToString();
                student.gender = Convert.ToInt32( oReader["Gender"].ToString());
                students.Add(student);
            }
            return students;
        }
        public static bool UpdateStudentInfo(Student student)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "UPDATE Student SET StudentName = @StudentName,DateOfBirth = @DateOfBirth, Gender = @Gender,ClassId = @ClassId Where StudentId = @StudentId";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@StudentId", student.studentId);
                command.Parameters.AddWithValue("@StudentName", student.studentName);
                command.Parameters.AddWithValue("@DateOfBirth", student.dateOfBirth);
                command.Parameters.AddWithValue("@Gender", student.gender);
                command.Parameters.AddWithValue("@ClassId", student.classId);
                conn.Open();
                command.ExecuteReader();
                return true;
            }
            catch(SqlException e)
            {
                return false;
            }
        }

        public static bool DeleteStudent(Student student)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "delete from Transcript where StudentId = @deleteId";
                string q1 = " delete from Presentation where StudentId = @deleteId";
                string q2 = "delete from Learning where StudentId = @deleteId";
                string q3 = "delete from Student where StudentId = @deleteId";
                SqlCommand command = new SqlCommand(queryString, conn);
                SqlCommand command1 = new SqlCommand(q1, conn);
                SqlCommand command2 = new SqlCommand(q2, conn);
                SqlCommand command3 = new SqlCommand(q3, conn);
                command.Parameters.AddWithValue("@deleteId", student.studentId);
                command1.Parameters.AddWithValue("@deleteId", student.studentId);
                command2.Parameters.AddWithValue("@deleteId", student.studentId);
                command3.Parameters.AddWithValue("@deleteId", student.studentId);

                conn.Open();
                command.ExecuteReader();
                conn.Close();
                conn.Open();
                command1.ExecuteReader();
                conn.Close();
                conn.Open();
                command2.ExecuteReader();
                conn.Close();
                conn.Open();
                command3.ExecuteReader();
                conn.Close();


                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }
        public static bool AddStudent(Student student)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();

                string queryString = "INSERT INTO Student VALUES (@StudentId,@StudentName,@DateOfBirth,@Gender,@ClassId)";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@StudentId", student.studentId);
                command.Parameters.AddWithValue("@StudentName", student.studentName);
                command.Parameters.AddWithValue("@DateOfBirth", student.dateOfBirth);
                command.Parameters.AddWithValue("@Gender", student.gender);
                command.Parameters.AddWithValue("@ClassId", student.classId);
                conn.Open();
                command.ExecuteReader();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }
        public static Student GetStudentInfoById(string studentID)
        {
            Student student = new Student();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();

                string queryString = "SELECT * FROM Student WHERE StudentId = @StudentId";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@StudentId", studentID);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                if (!oReader.Read())
                {
                    throw new InvalidOperationException("No records were returned.");
                }
                student.classId = oReader["ClassId"].ToString();
                student.dateOfBirth = oReader["DateOfBirth"].ToString();
                student.studentId = oReader["StudentId"].ToString();
                student.studentName = oReader["StudentName"].ToString();
                student.gender = Convert.ToInt32(oReader["Gender"].ToString());
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return student;
        }
        public static bool HandlePresentation(string studentID, string subjectID)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string queryString = "INSERT INTO Presentation VALUES (@StudentId, @SubjectId, @time)";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@StudentId", studentID);
                command.Parameters.AddWithValue("@SubjectId", subjectID);
                command.Parameters.AddWithValue("@time", sqlFormattedDate);
                conn.Open();
                command.ExecuteReader();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }
        public static List<Subject>GetAllSubject()
        {
            List<Subject> subjects = new List<Subject>();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "SELECT * FROM Subject";
                SqlCommand command = new SqlCommand(queryString, conn);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                while (oReader.Read())
                {
                    Subject subject = new Subject();
                    subject.subjectName = oReader["SubjectName"].ToString();
                    subject.time = oReader["Time"].ToString();
                    subject.dayOfWeek = Convert.ToInt32(oReader["DayOfWeek"].ToString());
                    subject.subjectId = oReader["SubjectId"].ToString();

                    subjects.Add(subject);
                }
            }
            catch (SqlException e)
            {
            }
            return subjects;
        }
    }
}
