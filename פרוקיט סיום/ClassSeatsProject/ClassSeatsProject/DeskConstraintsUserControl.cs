using dal;
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
    public partial class DeskConstraintsUserControl : UserControl
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        public DeskConstraintsUserControl()
        {
            InitializeComponent();
            AddConstraints();

        }
        public void AddConstraints()
        {
            int r = 0, c = 0, count = 0 ;
            var consLst = db.PropertiesTbl;
            foreach (var cons in consLst)
            {
                CheckBox cb = new CheckBox();
                cb.Text = cons.PropName;
                cb.RightToLeft = RightToLeft.Yes;
                cb.Location = new Point(100 - r, 14 + c);
                this.Controls.Add(cb);
                count++;
                c += 20;
                if (count > 3)
                {
                    r += 100;
                    c = 0;
                    count = 0;
                }
            }
        }

        private void DeskConstraintsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
