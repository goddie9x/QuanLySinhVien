
using System.Windows.Forms;

namespace GUI
{
    partial class Pesentation
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
            this.PesentBtn = new System.Windows.Forms.Button();
            this.studentIDField = new System.Windows.Forms.TextBox();
            this.subjectSelects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentNameField = new System.Windows.Forms.TextBox();
            this.imagePrev = new System.Windows.Forms.PictureBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CaptureBtn = new System.Windows.Forms.Button();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.picturePreviewMin = new System.Windows.Forms.PictureBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.BackHomeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreviewMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PesentBtn
            // 
            this.PesentBtn.BackColor = System.Drawing.Color.Green;
            this.PesentBtn.Enabled = false;
            this.PesentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesentBtn.ForeColor = System.Drawing.Color.Yellow;
            this.PesentBtn.Location = new System.Drawing.Point(77, 238);
            this.PesentBtn.Name = "PesentBtn";
            this.PesentBtn.Size = new System.Drawing.Size(75, 60);
            this.PesentBtn.TabIndex = 0;
            this.PesentBtn.Text = "4. Pesent";
            this.PesentBtn.UseVisualStyleBackColor = false;
            this.PesentBtn.Click += new System.EventHandler(this.PesentBtn_Click);
            // 
            // studentIDField
            // 
            this.studentIDField.Location = new System.Drawing.Point(167, 70);
            this.studentIDField.Name = "studentIDField";
            this.studentIDField.Size = new System.Drawing.Size(118, 20);
            this.studentIDField.TabIndex = 4;
            // 
            // subjectSelects
            // 
            this.subjectSelects.FormattingEnabled = true;
            this.subjectSelects.Location = new System.Drawing.Point(496, 69);
            this.subjectSelects.Name = "subjectSelects";
            this.subjectSelects.Size = new System.Drawing.Size(118, 21);
            this.subjectSelects.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(358, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.ForeColor = System.Drawing.Color.Green;
            this.studentNameLabel.Location = new System.Drawing.Point(44, 35);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(102, 16);
            this.studentNameLabel.TabIndex = 2;
            this.studentNameLabel.Text = "Student name";
            // 
            // studentNameField
            // 
            this.studentNameField.Location = new System.Drawing.Point(167, 35);
            this.studentNameField.Name = "studentNameField";
            this.studentNameField.Size = new System.Drawing.Size(118, 20);
            this.studentNameField.TabIndex = 1;
            // 
            // imagePrev
            // 
            this.imagePrev.Cursor = System.Windows.Forms.Cursors.Default;
            this.imagePrev.Location = new System.Drawing.Point(207, 143);
            this.imagePrev.Name = "imagePrev";
            this.imagePrev.Size = new System.Drawing.Size(469, 295);
            this.imagePrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePrev.TabIndex = 9;
            this.imagePrev.TabStop = false;
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(496, 35);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(118, 21);
            this.cboDevice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(358, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "selected device";
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.BackColor = System.Drawing.Color.Green;
            this.CaptureBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureBtn.ForeColor = System.Drawing.Color.Yellow;
            this.CaptureBtn.Location = new System.Drawing.Point(6, 37);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(75, 60);
            this.CaptureBtn.TabIndex = 13;
            this.CaptureBtn.Text = "1. Capture";
            this.CaptureBtn.UseVisualStyleBackColor = false;
            this.CaptureBtn.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.BackColor = System.Drawing.Color.Green;
            this.btnDetectFaces.Enabled = false;
            this.btnDetectFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectFaces.ForeColor = System.Drawing.Color.Yellow;
            this.btnDetectFaces.Location = new System.Drawing.Point(116, 37);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(75, 60);
            this.btnDetectFaces.TabIndex = 14;
            this.btnDetectFaces.Text = "2. Detect Faces";
            this.btnDetectFaces.UseVisualStyleBackColor = false;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(34, 143);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(134, 131);
            this.picDetected.TabIndex = 15;
            this.picDetected.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Green;
            this.btnAddPerson.Enabled = false;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddPerson.Location = new System.Drawing.Point(6, 140);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 60);
            this.btnAddPerson.TabIndex = 16;
            this.btnAddPerson.Text = "3.1 Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // picturePreviewMin
            // 
            this.picturePreviewMin.Location = new System.Drawing.Point(34, 287);
            this.picturePreviewMin.Name = "picturePreviewMin";
            this.picturePreviewMin.Size = new System.Drawing.Size(134, 138);
            this.picturePreviewMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreviewMin.TabIndex = 17;
            this.picturePreviewMin.TabStop = false;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Green;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.ForeColor = System.Drawing.Color.Yellow;
            this.btnTrain.Location = new System.Drawing.Point(116, 140);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 60);
            this.btnTrain.TabIndex = 20;
            this.btnTrain.Text = "3.2 Train Image";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // BackHomeBtn
            // 
            this.BackHomeBtn.BackColor = System.Drawing.Color.Green;
            this.BackHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackHomeBtn.ForeColor = System.Drawing.Color.Yellow;
            this.BackHomeBtn.Location = new System.Drawing.Point(749, 35);
            this.BackHomeBtn.Name = "BackHomeBtn";
            this.BackHomeBtn.Size = new System.Drawing.Size(75, 60);
            this.BackHomeBtn.TabIndex = 21;
            this.BackHomeBtn.Text = "Home";
            this.BackHomeBtn.UseVisualStyleBackColor = false;
            this.BackHomeBtn.Click += new System.EventHandler(this.BackHomeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.CaptureBtn);
            this.groupBox1.Controls.Add(this.btnDetectFaces);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Controls.Add(this.btnAddPerson);
            this.groupBox1.Controls.Add(this.PesentBtn);
            this.groupBox1.Location = new System.Drawing.Point(688, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 322);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // Pesentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.BackHomeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picturePreviewMin);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.imagePrev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectSelects);
            this.Controls.Add(this.studentIDField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.studentNameField);
            this.Name = "Pesentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesentation";
            this.Activated += new System.EventHandler(this.Pesentation_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pesentation_Close);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pesentation_FormClosed);
            this.Load += new System.EventHandler(this.Pesentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreviewMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PesentBtn;
        private System.Windows.Forms.TextBox studentIDField;
        private System.Windows.Forms.ComboBox subjectSelects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.TextBox studentNameField;
        private System.Windows.Forms.PictureBox imagePrev;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label label4;
        private Button CaptureBtn;
        private Button btnDetectFaces;
        private PictureBox picDetected;
        private Button btnAddPerson;
        private PictureBox picturePreviewMin;
        private Button btnTrain;
        private Button BackHomeBtn;
        private GroupBox groupBox1;
    }
}