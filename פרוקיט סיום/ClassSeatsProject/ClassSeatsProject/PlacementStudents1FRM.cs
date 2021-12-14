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
    public partial class PlacementStudents1FRM : Form
    {
        public PlacementStudents1FRM()
        {
            InitializeComponent();
        }
        public void keyclick(object sender, EventArgs e)
        {
            PlacementStudents2FRM f = new PlacementStudents2FRM();
            f.Show();
            this.Hide();
        }

        private void txtline_TextChanged(object sender, EventArgs e)
        {
            int r = 0, k = 0;
          //  int[]arr = new int[6]; 
            for (int i = 1; i <= Convert.ToInt32(txtline.Text); i++)
            {
                Label l = new Label();
                l.Text = ":מספר שולחנות לטור" + i;
                l.Size = new Size(140, 28);
                l.Location = new Point(188, 40 + k);
                Controls.Add(l);
                TextBox tb = new TextBox();
                tb.Location = new Point(188, 70 + r);
                tb.Name = "txt" + i;
                Controls.Add(tb);
                r += 50;
                k += 50;
                //arr[i] = 1;
            }
            Button b = new Button();
            b.Size = new Size(140, 30);
            b.Text = "to finish";
            b.Location = new Point(188, 370);
            b.Click += keyclick;
            Controls.Add(b);
        }

        private void PlacementStudents1FRM_Load(object sender, EventArgs e)
        {

        }
    }
}