
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamManager));
            this.ExamGrid = new System.Windows.Forms.DataGridView();
            this.ExamIdField = new System.Windows.Forms.TextBox();
            this.HandleExamIDBtn = new System.Windows.Forms.Button();
            this.ExamIdlabel = new System.Windows.Forms.Label();
            this.ExamIDPanel = new System.Windows.Forms.Panel();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ExamGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.SubjectCol,
            this.timeOutCol,
            this.examNameCol,
            this.TypeCol});
            this.ExamGrid.Location = new System.Drawing.Point(126, 147);
            this.ExamGrid.Name = "ExamGrid";
            this.ExamGrid.RowHeadersVisible = false;
            this.ExamGrid.RowHeadersWidth = 30;
            this.ExamGrid.Size = new System.Drawing.Size(666, 303);
            this.ExamGrid.TabIndex = 6;
            this.ExamGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExamGrid_CellClick);
            // 
            // ExamIdField
            // 
            this.ExamIdField.Location = new System.Drawing.Point(118, 17);
            this.ExamIdField.Name = "ExamIdField";
            this.ExamIdField.Size = new System.Drawing.Size(111, 20);
            this.ExamIdField.TabIndex = 0;
            this.ExamIdField.TextChanged += new System.EventHandler(this.ExamIdField_TextChanged);
            // 
            // HandleExamIDBtn
            // 
            this.HandleExamIDBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.HandleExamIDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandleExamIDBtn.ForeColor = System.Drawing.Color.Yellow;
            this.HandleExamIDBtn.Location = new System.Drawing.Point(286, 17);
            this.HandleExamIDBtn.Name = "HandleExamIDBtn";
            this.HandleExamIDBtn.Size = new System.Drawing.Size(87, 26);
            this.HandleExamIDBtn.TabIndex = 3;
            this.HandleExamIDBtn.Text = "Do";
            this.HandleExamIDBtn.UseVisualStyleBackColor = false;
            this.HandleExamIDBtn.Click += new System.EventHandler(this.HandleExamIDBtn_Click);
            // 
            // ExamIdlabel
            // 
            this.ExamIdlabel.AutoSize = true;
            this.ExamIdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamIdlabel.ForeColor = System.Drawing.Color.Gold;
            this.ExamIdlabel.Location = new System.Drawing.Point(14, 17);
            this.ExamIdlabel.Name = "ExamIdlabel";
            this.ExamIdlabel.Size = new System.Drawing.Size(59, 16);
            this.ExamIdlabel.TabIndex = 1;
            this.ExamIdlabel.Text = "ExamId";
            // 
            // ExamIDPanel
            // 
            this.ExamIDPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.ExamIDPanel.Controls.Add(this.ExamIdField);
            this.ExamIDPanel.Controls.Add(this.HandleExamIDBtn);
            this.ExamIDPanel.Controls.Add(this.ExamIdlabel);
            this.ExamIDPanel.Location = new System.Drawing.Point(242, 57);
            this.ExamIDPanel.Name = "ExamIDPanel";
            this.ExamIDPanel.Size = new System.Drawing.Size(444, 56);
            this.ExamIDPanel.TabIndex = 5;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateBtn.Image")));
            this.CreateBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CreateBtn.Location = new System.Drawing.Point(735, 10);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(139, 38);
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HomeBtn.Location = new System.Drawing.Point(27, 10);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(151, 34);
            this.HomeBtn.TabIndex = 8;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(391, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Find An Examination";
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id";
            this.idCol.Name = "idCol";
            this.idCol.Width = 22;
            // 
            // SubjectCol
            // 
            this.SubjectCol.HeaderText = "Subject";
            this.SubjectCol.Name = "SubjectCol";
            this.SubjectCol.Width = 180;
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
            this.examNameCol.Width = 180;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            // 
            // ExamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ExamGrid);
            this.Controls.Add(this.ExamIDPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "ExamManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Exem";
            this.Load += new System.EventHandler(this.ExamManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamGrid)).EndInit();
            this.ExamIDPanel.ResumeLayout(false);
            this.ExamIDPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamGrid;
        private System.Windows.Forms.TextBox ExamIdField;
        private System.Windows.Forms.Button HandleExamIDBtn;
        private System.Windows.Forms.Label ExamIdlabel;
        private System.Windows.Forms.Panel ExamIDPanel;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn examNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
    }
}