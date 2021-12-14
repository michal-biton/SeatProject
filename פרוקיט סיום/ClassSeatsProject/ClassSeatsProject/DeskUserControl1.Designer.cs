namespace ClassSeatsProject
{
    partial class DeskUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeskUserControl));
            this.cmb_st2 = new System.Windows.Forms.ComboBox();
            this.cmb_st1 = new System.Windows.Forms.ComboBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_st2
            // 
            this.cmb_st2.AllowDrop = true;
            this.cmb_st2.FormattingEnabled = true;
            this.cmb_st2.Location = new System.Drawing.Point(11, 51);
            this.cmb_st2.Name = "cmb_st2";
            this.cmb_st2.Size = new System.Drawing.Size(79, 21);
            this.cmb_st2.TabIndex = 0;
            this.cmb_st2.SelectedIndexChanged += new System.EventHandler(this.cmb_st2_SelectedIndexChanged);
            this.cmb_st2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cmb_st2_DragDrop_1);
            this.cmb_st2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cmb_st2_DragEnter);
            // 
            // cmb_st1
            // 
            this.cmb_st1.AllowDrop = true;
            this.cmb_st1.FormattingEnabled = true;
            this.cmb_st1.Location = new System.Drawing.Point(118, 51);
            this.cmb_st1.Name = "cmb_st1";
            this.cmb_st1.Size = new System.Drawing.Size(68, 21);
            this.cmb_st1.TabIndex = 1;
            this.cmb_st1.SelectedIndexChanged += new System.EventHandler(this.cmb_st1_SelectedIndexChanged);
            this.cmb_st1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cmb_st1_DragDrop_1);
            this.cmb_st1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cmb_st1_DragEnter);
            // 
            // pb1
            // 
            this.pb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb1.BackgroundImage")));
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb1.ErrorImage")));
            this.pb1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb1.InitialImage")));
            this.pb1.Location = new System.Drawing.Point(128, 10);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(45, 39);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // btn_check
            // 
            this.btn_check.Enabled = false;
            this.btn_check.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(59, 77);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(87, 30);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "together?";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(139, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(146, 72);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 33);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "⏳";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pb2
            // 
            this.pb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb2.BackgroundImage")));
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb2.ErrorImage")));
            this.pb2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb2.InitialImage")));
            this.pb2.Location = new System.Drawing.Point(26, 10);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(45, 39);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "🗑";
            this.label2.Click += new System.EventHandler(this.lblResult_Click);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // DeskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.cmb_st1);
            this.Controls.Add(this.cmb_st2);
            this.Name = "DeskUserControl";
            this.Size = new System.Drawing.Size(228, 111);
            this.Load += new System.EventHandler(this.DeskUserControl1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DeskUserControl_DragEnter);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DeskUserControl_HelpRequested_1);
            this.MouseHover += new System.EventHandler(this.DeskUserControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_st2;
        private System.Windows.Forms.ComboBox cmb_st1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label2;
    }
}
