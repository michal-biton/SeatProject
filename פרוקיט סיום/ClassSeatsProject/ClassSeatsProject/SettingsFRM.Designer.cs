namespace ClassSeatsProject
{
    partial class SettingsFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFRM));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTables = new System.Windows.Forms.Panel();
            this.nupRows = new System.Windows.Forms.NumericUpDown();
            this.nupClassNum = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupClassNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(649, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = ":מספר טורים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(288, 28);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(176, 28);
            this.lblTittle.TabIndex = 9;
            this.lblTittle.Text = "הגדרות- מפת הכיתה";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClass.Location = new System.Drawing.Point(650, 123);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(94, 22);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "מספר כיתה";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelTables
            // 
            this.panelTables.Location = new System.Drawing.Point(109, 70);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(369, 355);
            this.panelTables.TabIndex = 10;
            // 
            // nupRows
            // 
            this.nupRows.Location = new System.Drawing.Point(565, 170);
            this.nupRows.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupRows.Name = "nupRows";
            this.nupRows.Size = new System.Drawing.Size(79, 20);
            this.nupRows.TabIndex = 11;
            this.nupRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupClassNum
            // 
            this.nupClassNum.Location = new System.Drawing.Point(565, 123);
            this.nupClassNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupClassNum.Name = "nupClassNum";
            this.nupClassNum.Size = new System.Drawing.Size(79, 20);
            this.nupClassNum.TabIndex = 13;
            this.nupClassNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowRows
            // 
            this.btnShowRows.BackColor = System.Drawing.Color.Maroon;
            this.btnShowRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnShowRows.ForeColor = System.Drawing.Color.White;
            this.btnShowRows.Location = new System.Drawing.Point(603, 211);
            this.btnShowRows.Name = "btnShowRows";
            this.btnShowRows.Size = new System.Drawing.Size(68, 30);
            this.btnShowRows.TabIndex = 99;
            this.btnShowRows.Text = "show";
            this.btnShowRows.UseVisualStyleBackColor = false;
            this.btnShowRows.Click += new System.EventHandler(this.btnShowRows_Click);
            // 
            // SettingsFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowRows);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nupClassNum);
            this.Controls.Add(this.nupRows);
            this.Controls.Add(this.panelTables);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsFRM";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupClassNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.NumericUpDown nupRows;
        private System.Windows.Forms.NumericUpDown nupClassNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowRows;
    }
}