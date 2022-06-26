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
            DataTable students = new DataTable();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "SELECT * FROM Student";
                SqlCommand command = new SqlCommand(queryString, conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(students);
            }
            catch (SqlException e)
            {
            }
            return students;
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
            conn.Close();
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
                conn.Close();
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
                string queryString = "delete from Account where sAccountID = @deleteId ;"
                    + "  delete from Presentation where StudentId = @deleteId ;"
                    + "  delete from Learning where StudentId = @deleteId ;"
                    + "  delete from Student where StudentId = @deleteId ;";
                SqlCommand command = new SqlCommand(queryString, conn);;
                command.Parameters.AddWithValue("@deleteId", student.studentId);
                conn.Open();
                command.ExecuteReader();
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
                conn.Close();
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
                conn.Close();
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
                string queryString = "INSERT INTO Presentation VALUES (\'"+ studentID+"\',\'"+ subjectID + "\',\'" + sqlFormattedDate+"\')";
                SqlCommand command = new SqlCommand(queryString, conn);
                conn.Open();
                command.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }
        public static DataTable GetAllSubjectDataTable()
        {
            DataTable subjects = new DataTable();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "SELECT * FROM Subject";
                SqlCommand command = new SqlCommand(queryString, conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(subjects);
                conn.Close();
            }
            catch (SqlException e)
            {
            }
            return subjects;
        }
        public static List<Subject> GetAllSubject()
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
                    subject.timeStart = oReader["TimeStart"].ToString();
                    subject.timeEnd = oReader["TimeEnd"].ToString();
                    subject.dayOfWeek = Convert.ToInt32(oReader["DayOfWeek"].ToString());
                    subject.subjectId = oReader["SubjectId"].ToString();
                    subjects.Add(subject);
                }

                conn.Close();
            }
            catch (SqlException e)
            {
            }
            return subjects;
        }
        public static List<Subject> GetAllSubjectAreLearningThisSemester(int semester)
        {
            List<Subject> subjects = new List<Subject>();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select DISTINCT sj.SubjectId, sj.SubjectName, sj.DayOfWeek, sj.TimeStart, sj.TimeEnd from Learning as Learn left join Subject as sj on" +
                    " sj.SubjectId = Learn.SubjectId where Semester = @semester";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.Add("@semester", semester);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                while (oReader.Read())
                {
                    Subject subject = new Subject();

                    subject.subjectName = oReader["SubjectName"].ToString();
                    subject.timeStart = oReader["TimeStart"].ToString();
                    subject.timeEnd = oReader["TimeEnd"].ToString();
                    subject.dayOfWeek = Convert.ToInt32(oReader["DayOfWeek"].ToString());
                    subject.subjectId = oReader["SubjectId"].ToString();
                    subjects.Add(subject);
                }

                conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return subjects;
        }
        public static List<Subject> GetAllSubjectAreLearningThisSemesterAndStudentId(int semester,string StudentId)
        {
            List<Subject> subjects = new List<Subject>();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select DISTINCT sj.SubjectId, sj.SubjectName, sj.DayOfWeek, sj.TimeStart, sj.TimeEnd from Learning as Learn left join Subject as sj on" +
                    " sj.SubjectId = Learn.SubjectId where Semester = @semester and StudentId = @StudentId";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.Add("@semester", semester);
                command.Parameters.Add("@StudentId", StudentId);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                while (oReader.Read())
                {
                    Subject subject = new Subject();

                    subject.subjectName = oReader["SubjectName"].ToString();
                    subject.timeStart = oReader["TimeStart"].ToString();
                    subject.timeEnd = oReader["TimeEnd"].ToString();
                    subject.dayOfWeek = Convert.ToInt32(oReader["DayOfWeek"].ToString());
                    subject.subjectId = oReader["SubjectId"].ToString();
                    subjects.Add(subject);
                }

                conn.Close();
            }
            catch (SqlException e)
            {
            }
            return subjects;
        }
        public static DataTable GetTransctriptByQuery(string query)
        {
            DataTable subjects = new DataTable();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select LeaningId,SubjectName,DayOfWeek,TimeStart,TimeEnd,StudentName"
                    + ",ClassName,PointMid,PointEnd,AmountPesented,AmountPesentedLate from Learning "
                    + " inner join Student on Learning.StudentId = Student.StudentId "
                    + " inner join Subject on Subject.SubjectId = Learning.SubjectId "
                    + " inner join Class on Class.ClassId = Student.ClassId where "+ query;
                SqlCommand command = new SqlCommand(queryString, conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(subjects);
                conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        return subjects;
        } 

        public static bool Pesent(string StudentId, string SubjectId,bool isLate = false)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "handle_presentation";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentId", StudentId);
                command.Parameters.AddWithValue("@SubjectId", SubjectId);
                command.Parameters.AddWithValue("@isLate", isLate);
                var returnParameter = command.Parameters.Add("@IsSuccess", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                conn.Open();
                command.ExecuteNonQuery();
                int IsSuccess = (int)returnParameter.Value;
                conn.Close();
                if (IsSuccess == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public static string[] GetUniversityInfo()
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select top 1 * from UniversityInfo";
                SqlCommand command = new SqlCommand(queryString, conn);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                oReader.Read();
                string[]univerInfo = new string[] { 
                    oReader["UniversityName"].ToString(),
                    oReader["UniversityShortName"].ToString(),
                    oReader["YeahEstablish"].ToString()
                };
                conn.Close();
                return univerInfo;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
        //pointType: PointMid, PointEnd
        public static bool EditPoint(string LearningId,string pointType,int point)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "update TOP (1) Learning set Learning."+ pointType+" = @point where LeaningId = @LearningId";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@LearningId", LearningId);
                command.Parameters.AddWithValue("@point", point);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public static bool SetExamPoint(string SubjectId, string Semester, int termType, int point, string sAccountID, string ExamId)
        {
            string pointType = termType == 0 ? "PointMid" : "PointEnd";
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "update TOP (1) Learning set Learning." + pointType + " = @point where SubjectId" +
                    " = @SubjectId and Semester = @Semester ;  insert into TookExam values (@sAccountID,@ExamId)";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@SubjectId", SubjectId);
                command.Parameters.AddWithValue("@Semester", Semester);
                command.Parameters.AddWithValue("@point", point);
                command.Parameters.AddWithValue("@sAccountID", sAccountID);
                command.Parameters.AddWithValue("@ExamId", ExamId);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public static Exam GetExamById(string ExamId)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select top(1)* from Exam where id = @ExamId";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@ExamId", ExamId);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                oReader.Read();
                Exam exam = new Exam(oReader["id"].ToString(), oReader["SubjectId"].ToString(), oReader["timeOut"].ToString(),
                    oReader["examName"].ToString(), oReader["type"].ToString(), oReader["sAccountID"].ToString(),oReader["Semester"].ToString());
                conn.Close();
                return exam;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public static bool CheckUserTookExam(string sAccountID,string ExamId)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select top(1)* from TookExam where sAccountID = @sAccountID and ExamId = @ExamId";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@ExamId", ExamId);
                command.Parameters.AddWithValue("@sAccountID", sAccountID);
                conn.Open();
                return command.ExecuteScalar() != null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public static List<Exam> GetAllExamCreatedByAccountID(string sAccountID)
        {
            List<Exam> Exams = new List<Exam>();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select * from Exam where sAccountID = @sAccountID";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@sAccountID", sAccountID);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                while (oReader.Read())
                {
                    Exam crrExam  = new Exam(oReader["id"].ToString(), oReader["SubjectId"].ToString(), oReader["timeOut"].ToString(),
                    oReader["examName"].ToString(), oReader["type"].ToString(), oReader["sAccountID"].ToString(), oReader["Semester"].ToString());
                    Exams.Add(crrExam);
                }

                conn.Close();
                return Exams;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return Exams;
            }
        }
        public static List<QuestionItemInfo> GetQuestionItemInfosByExamId(string ExamId)
        {
            List<QuestionItemInfo> questionItemInfos = new List<QuestionItemInfo>();
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "select * from Question where ExamId = @ExamId order by questionIndex DESC";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@ExamId", ExamId);
                conn.Open();
                SqlDataReader oReader = command.ExecuteReader();
                while (oReader.Read())
                {
                    QuestionItemInfo questionItemInfo = new QuestionItemInfo(
                        oReader["id"].ToString(),
                        oReader["ExamId"].ToString(),
                        oReader["question"].ToString(),
                        oReader["answers"].ToString(),
                        oReader["radioAnswer"].ToString(),
                        oReader["checkBoxAnswers"].ToString(),
                        oReader["questionIndex"].ToString()
                        );
                    questionItemInfos.Add(questionItemInfo);
                }
                conn.Close();
                return questionItemInfos;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return questionItemInfos;
            }
        }
        public static string CreateExam(Exam exam)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "insert into Exam output inserted.id values(@SubjectId, @timeOut, N'@examName',@type,@sAccountID,@Semester)";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@SubjectId", exam.SubjectId);
                command.Parameters.AddWithValue("@timeOut", exam.timeOut);
                command.Parameters.AddWithValue("@examName", exam.examName);
                command.Parameters.AddWithValue("@type", exam.type);
                command.Parameters.AddWithValue("@sAccountID", exam.sAccountID);
                command.Parameters.AddWithValue("@Semester", exam.Semester);
                conn.Open();
                int serviceID=(int)command.ExecuteScalar();
                conn.Close();
                return ""+serviceID;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return "";
            }
        }
        public static bool EditExam(Exam exam)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "update Exam set SubjectId = @SubjectId, timeOut = @timeOut,examName = N'@examName'," +
                    " type = @type,sAccountID = @sAccountID,Semester = @Semester where id = @id";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@SubjectId", exam.SubjectId);
                command.Parameters.AddWithValue("@timeOut", exam.timeOut);
                command.Parameters.AddWithValue("@examName", exam.examName);
                command.Parameters.AddWithValue("@type", exam.type);
                command.Parameters.AddWithValue("@sAccountID", exam.sAccountID);
                command.Parameters.AddWithValue("@Semester", exam.Semester);
                command.Parameters.AddWithValue("@id", exam.id);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public static bool CreatQuestion(QuestionItemInfo questionItem)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string queryString = "insert into Question values(@ExamId, @question, @answers,@radioAnswer, @checkBoxAnswers, @questionIndex)";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@ExamId", questionItem.ExamId);
                command.Parameters.AddWithValue("@question", questionItem.question);
                command.Parameters.AddWithValue("@answers", questionItem.answers);
                command.Parameters.AddWithValue("@radioAnswer", questionItem.radioAnswer);
                command.Parameters.AddWithValue("@checkBoxAnswers", questionItem.checkBoxAnswers);
                command.Parameters.AddWithValue("@questionIndex", questionItem.index);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        public static bool UpdateQuestion(QuestionItemInfo questionItem)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                string procedure = "CreateOrUpdateQuestion";
                SqlCommand command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ExamId", questionItem.ExamId);
                command.Parameters.AddWithValue("@question", questionItem.question);
                command.Parameters.AddWithValue("@answers", questionItem.answers);
                command.Parameters.AddWithValue("@radioAnswer", questionItem.radioAnswer);
                command.Parameters.AddWithValue("@checkBoxAnswers", questionItem.checkBoxAnswers);
                command.Parameters.AddWithValue("@questionIndex", questionItem.index);
                command.Parameters.AddWithValue("@id", questionItem.id);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
