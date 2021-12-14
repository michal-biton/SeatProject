namespace ClassSeatsProject
{
    partial class PlacementStudentsFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacementStudentsFRM));
            this.students = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelClass = new System.Windows.Forms.Panel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.pteacher = new System.Windows.Forms.Panel();
            this.Pbteacher = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbteacher = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnsaveP = new System.Windows.Forms.Button();
            this.pteacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbteacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // students
            // 
            this.students.AllowDrop = true;
            this.students.FormattingEnabled = true;
            this.students.Location = new System.Drawing.Point(1700, 176);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(144, 290);
            this.students.TabIndex = 98;
            this.students.DragEnter += new System.Windows.Forms.DragEventHandler(this.students_DragEnter);
            this.students.MouseDown += new System.Windows.Forms.MouseEventHandler(this.students_MouseDown);
            // 
            // panelClass
            // 
            this.panelClass.Location = new System.Drawing.Point(12, 24);
            this.panelClass.Name = "panelClass";
            this.panelClass.Size = new System.Drawing.Size(1472, 634);
            this.panelClass.TabIndex = 99;
            this.panelClass.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClass_Paint);
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(1700, 74);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(120, 21);
            this.cmbClass.TabIndex = 100;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClass.Location = new System.Drawing.Point(1693, 38);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(136, 22);
            this.lblClass.TabIndex = 101;
            this.lblClass.Text = "בחר כיתה לשיבוץ";
            // 
            // pteacher
            // 
            this.pteacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pteacher.Controls.Add(this.Pbteacher);
            this.pteacher.Controls.Add(this.label1);
            this.pteacher.Controls.Add(this.cbteacher);
            this.pteacher.Location = new System.Drawing.Point(633, 701);
            this.pteacher.Name = "pteacher";
            this.pteacher.Size = new System.Drawing.Size(314, 117);
            this.pteacher.TabIndex = 0;
            this.pteacher.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pbteacher
            // 
            this.Pbteacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pbteacher.BackgroundImage")));
            this.Pbteacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pbteacher.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Pbteacher.ErrorImage")));
            this.Pbteacher.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pbteacher.InitialImage")));
            this.Pbteacher.Location = new System.Drawing.Point(18, 7);
            this.Pbteacher.Name = "Pbteacher";
            this.Pbteacher.Size = new System.Drawing.Size(103, 96);
            this.Pbteacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbteacher.TabIndex = 3;
            this.Pbteacher.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "לבחירת המורה המלמדת";
            // 
            // cbteacher
            // 
            this.cbteacher.FormattingEnabled = true;
            this.cbteacher.Items.AddRange(new object[] {
            "המורה צופיה",
            "המורה אדלשטין",
            "המורה גילה לוי",
            "המורה אלינסון"});
            this.cbteacher.Location = new System.Drawing.Point(179, 57);
            this.cbteacher.Name = "cbteacher";
            this.cbteacher.Size = new System.Drawing.Size(90, 21);
            this.cbteacher.TabIndex = 1;
            this.cbteacher.SelectedIndexChanged += new System.EventHandler(this.cbteacher_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 693);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Maroon;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(1741, 111);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(61, 37);
            this.btnOk.TabIndex = 105;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnsaveP
            // 
            this.btnsaveP.BackColor = System.Drawing.Color.Maroon;
            this.btnsaveP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnsaveP.ForeColor = System.Drawing.Color.White;
            this.btnsaveP.Location = new System.Drawing.Point(1719, 475);
            this.btnsaveP.Name = "btnsaveP";
            this.btnsaveP.Size = new System.Drawing.Size(113, 57);
            this.btnsaveP.TabIndex = 105;
            this.btnsaveP.Text = "לשמירת  השיבוץ";
            this.btnsaveP.UseVisualStyleBackColor = false;
            this.btnsaveP.Click += new System.EventHandler(this.btnsaveP_Click);
            // 
            // PlacementStudentsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1856, 1061);
            this.Controls.Add(this.btnsaveP);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pteacher);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.students);
            this.Controls.Add(this.panelClass);
            this.Name = "PlacementStudentsFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PlacementStudents2FRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlacementStudents2FRM_Load_1);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PlacementStudentsFRM_HelpRequested);
            this.pteacher.ResumeLayout(false);
            this.pteacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbteacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox students;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Panel pteacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbteacher;
        private System.Windows.Forms.PictureBox Pbteacher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnsaveP;
    }
}