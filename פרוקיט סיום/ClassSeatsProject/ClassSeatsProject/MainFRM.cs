using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassSeatsProject
{
    public partial class MainFRM : Form
    {
          public MainFRM()
        {
            InitializeComponent();
            lstbox.Visible = true;
        }

        private void הגדרותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsFRM f1 = new SettingsFRM();
            f1.Show();
        }

        private void הוספתתלמידותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentFRM f1 = new AddStudentFRM();
            f1.Show();
        }

        private void עדכוןאילוציתלמידותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstraintUpdateFRM f1 = new ConstraintUpdateFRM();
            f1.Show();
        }

        private void שיבוץתלמידותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlacementStudentsFRM f1 = new PlacementStudentsFRM();
            f1.Show();
        }

        private void מפתכיתהאליוציםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("להוספת אילוצי שלחן בחר כיתה חדשה");
        }

        private void MainFRM_Load(object sender, EventArgs e)
        {

        }
       
      
        private void dalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
