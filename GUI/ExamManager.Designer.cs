
namespace GUI
{
    partial class ExamManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExamGrid = new System.Windows.Forms.DataGridView();
            this.ExamIdField = new System.Windows.Forms.TextBox();
            this.HandleExamIDBtn = new System.Windows.Forms.Button();
            this.ExamIdlabel = new System.Windows.Forms.Label();
            this.ExamIDPanel = new System.Windows.Forms.Panel();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExamGrid)).BeginInit();
            this.ExamIDPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExamGrid
            // 
            this.ExamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.SubjectCol,
            this.timeOutCol,
            this.examNameCol,
            this.TypeCol});
            this.ExamGrid.Location = new System.Drawing.Point(26, 68);
            this.ExamGrid.Name = "ExamGrid";
            this.ExamGrid.RowHeadersVisible = false;
            this.ExamGrid.Size = new System.Drawing.Size(748, 363);
            this.ExamGrid.TabIndex = 6;
            this.ExamGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExamGrid_CellClick);
            // 
            // ExamIdField
            // 
            this.ExamIdField.Location = new System.Drawing.Point(71, 3);
            this.ExamIdField.Name = "ExamIdField";
            this.ExamIdField.Size = new System.Drawing.Size(179, 20);
            this.ExamIdField.TabIndex = 0;
            this.ExamIdField.TextChanged += new System.EventHandler(this.ExamIdField_TextChanged);
            // 
            // HandleExamIDBtn
            // 
            this.HandleExamIDBtn.Location = new System.Drawing.Point(256, 1);
            this.HandleExamIDBtn.Name = "HandleExamIDBtn";
            this.HandleExamIDBtn.Size = new System.Drawing.Size(75, 23);
            this.HandleExamIDBtn.TabIndex = 3;
            this.HandleExamIDBtn.Text = "Do";
            this.HandleExamIDBtn.UseVisualStyleBackColor = true;
            this.HandleExamIDBtn.Click += new System.EventHandler(this.HandleExamIDBtn_Click);
            // 
            // ExamIdlabel
            // 
            this.ExamIdlabel.AutoSize = true;
            this.ExamIdlabel.Location = new System.Drawing.Point(12, 6);
            this.ExamIdlabel.Name = "ExamIdlabel";
            this.ExamIdlabel.Size = new System.Drawing.Size(42, 13);
            this.ExamIdlabel.TabIndex = 1;
            this.ExamIdlabel.Text = "ExamId";
            // 
            // ExamIDPanel
            // 
            this.ExamIDPanel.Controls.Add(this.ExamIdField);
            this.ExamIDPanel.Controls.Add(this.HandleExamIDBtn);
            this.ExamIDPanel.Controls.Add(this.ExamIdlabel);
            this.ExamIDPanel.Location = new System.Drawing.Point(26, 12);
            this.ExamIDPanel.Name = "ExamIDPanel";
            this.ExamIDPanel.Size = new System.Drawing.Size(341, 27);
            this.ExamIDPanel.TabIndex = 5;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(579, 12);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(699, 13);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(75, 23);
            this.HomeBtn.TabIndex = 8;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id";
            this.idCol.Name = "idCol";
            this.idCol.Width = 20;
            // 
            // SubjectCol
            // 
            this.SubjectCol.HeaderText = "Subject";
            this.SubjectCol.Name = "SubjectCol";
            this.SubjectCol.Width = 200;
            // 
            // timeOutCol
            // 
            this.timeOutCol.HeaderText = "time out";
            this.timeOutCol.Name = "timeOutCol";
            this.timeOutCol.Width = 180;
            // 
            // examNameCol
            // 
            this.examNameCol.HeaderText = "Exam name";
            this.examNameCol.Name = "examNameCol";
            this.examNameCol.Width = 200;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.Width = 180;
            // 
            // ExamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ExamGrid);
            this.Controls.Add(this.ExamIDPanel);
            this.Name = "ExamManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Exem";
            this.Load += new System.EventHandler(this.ExamManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamGrid)).EndInit();
            this.ExamIDPanel.ResumeLayout(false);
            this.ExamIDPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamGrid;
        private System.Windows.Forms.TextBox ExamIdField;
        private System.Windows.Forms.Button HandleExamIDBtn;
        private System.Windows.Forms.Label ExamIdlabel;
        private System.Windows.Forms.Panel ExamIDPanel;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn examNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
    }
}