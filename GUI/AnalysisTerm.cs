using System;
using System.Data;
using Syncfusion.XlsIO;
using System.Windows.Forms;
using System.IO;
using BUS;
using System.Diagnostics;
using System.Linq;
using DAL;

namespace GUI
{
    public partial class AnalysisTerm : Form
    {
        SubjectBUS sjbus = new SubjectBUS();
        TranscrioptBUS tsBus = new TranscrioptBUS();
        GeneralBUS generalBUS = new GeneralBUS();
        public AnalysisTerm()
        {
            InitializeComponent();
            GetAllSubject();
            InitSementerSelection();
            if (Login.account.RoleID == 2)
            {
                StudentLabel.Visible = false;
                studentQueryText.Visible = false;
            }
        }

        private void GetAllSubject()
        {
            SubjectSelect.DataSource = sjbus.GetAllSubject().Select(s => s.subjectName).ToList();
        }
        private void InitSementerSelection()
        {
            int amountSementer = generalBUS.GetCurrentSemester();
            SemesterSelect.Items.Add("Select semeter");
            for (int i = 1;i<= amountSementer; i++)
            {
                int currentYear = DateTime.Now.Year - (amountSementer - i) / 2;
                string semeterItem = "semeter " + (i % 2 + 1) + " (year "+ currentYear + ")";
                SemesterSelect.Items.Add(semeterItem);
            }
        }

        private void FilterTranscript() 
        {
            string query = "Subject.SubjectName = \'" + SubjectSelect.SelectedItem + "\'";
            string studentTextQuery = studentQueryText.Text.Trim().Replace("'", "''");
            if (SemesterSelect.SelectedIndex>0)
            {
                query += " and Learning.Semester = " + SemesterSelect.SelectedIndex;
            }
            if (studentTextQuery != "")
            {
                query += " and (Student.StudentId = \'" + studentTextQuery + "\' or Student.StudentName = \'" + studentTextQuery + "\')";
            }
            if (Login.account.RoleID == 2)
            {
                query += " and Student.StudentId = \'" + Login.account.sUsername + "\'";
            }
            AnalysisTermTable.DataSource = tsBus.GetTransctriptByQuery(query);
        }
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel.Enabled = false;
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Create a new workbook
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet sheet = workbook.Worksheets[0];

                //Import data from the data table with column header, at first row and first column, 
                //and by its column type.
                sheet.ImportDataTable((DataTable)AnalysisTermTable.DataSource, true, 1, 1, true);

                //Creating Excel table or list object and apply style to the table
                IListObject table = sheet.ListObjects.Create("AnalysisTerm", sheet.UsedRange);

                table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium14;

                //Autofit the columns
                sheet.UsedRange.AutofitColumns();

                //Save the file in the given path
                Stream excelStream = File.Create(Path.GetFullPath(@"OutpAnalysisTermut.xlsx"));
                workbook.SaveAs(excelStream);
                excelStream.Dispose();
                Process.Start(@"OutpAnalysisTermut.xlsx");
            }
        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            if (Home.instance == null)
            {
                Home.instance = new Home();
            }
            this.Hide();
            Home.instance.Show();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            FilterTranscript();
        }

        private void AnalysisTermTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            int point;
            string pointType;
            //colIndex.pointType: 7.PointMid, 8.PointEnd
            switch (colIndex)
            {
                case 7:
                    {
                        pointType = "PointMid";
                        break;
                    }
                case 8:
                    {
                        pointType = "PointEnd";
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            string LeaningId = AnalysisTermTable.Rows[rowIndex].Cells[0].Value.ToString();
            if(int.TryParse(AnalysisTermTable.Rows[rowIndex].Cells[colIndex].Value.ToString(), out point))
            {
                if (point < 0 || point > 10)
                {
                    MessageBox.Show("Point must be >= 0 and <= 10!");
                    FilterTranscript();
                    return;
                }
                if (DatabaseAccess.EditPoint(LeaningId, pointType, point))
                {
                    MessageBox.Show("Edit point success!");
                }
                else
                {
                    MessageBox.Show("Edit point failed!");
                }
            }
            else
            {
                MessageBox.Show("Please input interger!");
            }
            FilterTranscript();
        }

        private void ToggleEditBtn_Click(object sender, EventArgs e)
        {
            AnalysisTermTable.Enabled = !AnalysisTermTable.Enabled;
        }

        private void AnalysisTerm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
