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
    public partial class PlacementStudents2FRM : Form
    {
        public PlacementStudents2FRM()
        {
            InitializeComponent();
            DeskUserControl1 d = new DeskUserControl1();
            d.line = 0;
            d.row = 0;
            d.ct = 0;
            //   d.student1 =;
            //  d.student2 =;
            Controls.Add(d);
            Controls.Remove(d);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    DeskUserControl1 d1 = new DeskUserControl1();
                    d1.line = 0;
                    d1.row = 0;
                    d1.ct = 0;
                    //   d.student1 =;
                    //  d.student2 =;
                    Controls.Add(d1);
                    Controls.Remove(d1);
                }
            }
        }

        private void PlacementStudents2FRM_Load(object sender, EventArgs e)
        {

        }

        private void PlacementStudents2FRM_Load_1(object sender, EventArgs e)
        {

        }
    }
}
