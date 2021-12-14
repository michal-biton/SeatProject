namespace ClassSeatsProject
{
    partial class AddStudentFRM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentFRM));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgstudent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDchat = new System.Windows.Forms.NumericUpDown();
            this.NUDline = new System.Windows.Forms.NumericUpDown();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtimage = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDline)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Maroon;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(252, 280);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 40);
            this.btnNew.TabIndex = 90;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BuChadash_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(142, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 40);
            this.btnUpdate.TabIndex = 88;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BuHidcun_Click);
            // 
            // dgstudent
            // 
            this.dgstudent.BackgroundColor = System.Drawing.Color.White;
            this.dgstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstudent.Location = new System.Drawing.Point(28, 12);
            this.dgstudent.MultiSelect = false;
            this.dgstudent.Name = "dgstudent";
            this.dgstudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgstudent.RowHeadersWidth = 51;
            this.dgstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgstudent.Size = new System.Drawing.Size(829, 253);
            this.dgstudent.TabIndex = 87;
            this.dgstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgstudent_CellContentClick);
            this.dgstudent.SelectionChanged += new System.EventHandler(this.dgstudent_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(317, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "שם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(317, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "כיתה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(317, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "דרגת פטפוט";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(317, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "שורה מומלצת";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(317, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "משפחה";
            // 
            // NUDchat
            // 
            this.NUDchat.Location = new System.Drawing.Point(266, 152);
            this.NUDchat.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDchat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDchat.Name = "NUDchat";
            this.NUDchat.Size = new System.Drawing.Size(31, 20);
            this.NUDchat.TabIndex = 93;
            this.NUDchat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDchat.ValueChanged += new System.EventHandler(this.NUDchat_ValueChanged);
            // 
            // NUDline
            // 
            this.NUDline.Location = new System.Drawing.Point(266, 180);
            this.NUDline.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUDline.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDline.Name = "NUDline";
            this.NUDline.Size = new System.Drawing.Size(31, 20);
            this.NUDline.TabIndex = 93;
            this.NUDline.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDline.ValueChanged += new System.EventHandler(this.NUDline_ValueChanged);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(242, 38);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(69, 20);
            this.txtfname.TabIndex = 94;
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(242, 65);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(69, 20);
            this.txtlname.TabIndex = 94;
            this.txtlname.TextChanged += new System.EventHandler(this.txtlname_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.txtlname);
            this.panel1.Controls.Add(this.txtimage);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtfname);
            this.panel1.Controls.Add(this.NUDline);
            this.panel1.Controls.Add(this.NUDchat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(374, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 216);
            this.panel1.TabIndex = 95;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(242, 91);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(69, 21);
            this.cmbClass.TabIndex = 97;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Maroon;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(55, 79);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(118, 42);
            this.btncancel.TabIndex = 95;
            this.btncancel.Text = "ביטול";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Maroon;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(55, 24);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(118, 42);
            this.btnok.TabIndex = 96;
            this.btnok.Text = "אישור";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtimage
            // 
            this.txtimage.Location = new System.Drawing.Point(242, 117);
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(69, 20);
            this.txtimage.TabIndex = 94;
            this.txtimage.TextChanged += new System.EventHandler(this.txtclass_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(242, 13);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(69, 20);
            this.txtid.TabIndex = 94;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(317, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 92;
            this.label7.Text = "נתיב תמונה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "מזהה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(28, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 40);
            this.btnDelete.TabIndex = 97;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddStudentFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 508);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgstudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudentFRM";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudentFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDline)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.NumericUpDown NUDline;
        private System.Windows.Forms.NumericUpDown NUDchat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgstudent;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtimage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
    }
}