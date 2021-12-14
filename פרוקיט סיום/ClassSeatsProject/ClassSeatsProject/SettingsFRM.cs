using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using dal;
using bll;

namespace ClassSeatsProject
{
    public partial class SettingsFRM : Form
    {


        RuthProjectEntities db = RuthProjectEntities.Instance();
        public SettingsFRM()
        {
            InitializeComponent();
            
        }

        private void SettingsFRM_Load(object sender, EventArgs e)
        {

        }

        public void keyclick(object sender, EventArgs e)
        {
            // EnterClassToDB();
            //  SaveInXML();
            //AddStudentFRM f = new AddStudentFRM();
            //f.Show();
            List<int> tables = new List<int>();
            foreach (var item in panelTables.Controls)
            {
                if (item.GetType().Name == "NumericUpDown")
                {
                    tables.Add(Convert.ToInt32((item as NumericUpDown).Value));
                }
            }
            MapSettingFrm mapForm = new MapSettingFrm(Convert.ToInt32(nupClassNum.Text), Convert.ToInt32(nupRows.Value), tables);
            mapForm.Show();
            this.Hide();
        }
        //public void EnterClassToDB()
        //{
        //    ClassTbl c = new ClassTbl() { };
        //    bool flag = true;
        //    //var clsNames = db.ClassTbl.Select(x => new { x.ClassName });
        //    //if (clsNames==null||(clsNames != null && clsNames.First(x => x.ClassName == txtClassCode.Text) != null))

        //    //{
        //        try
        //        {
        //            c.ClassName = txtClassCode.Text;
        //        }
        //        catch
        //        {
        //            errorProvider1.SetError(txtClassCode, "not valid");
        //            flag = false;
        //        }
        //    //}
        //    //else
        //    //{
        //    //    errorProvider1.SetError(txtClassCode, "there is alredy class called " + txtClassCode.Text);
        //    //    flag = false;
        //    //}
        //    if (flag)
        //    {
        //        db.ClassTbl.Add(c);
        //        db.SaveChanges();
        //        codeNewClass = c.ClassId;
        //    }
        //    else
        //        MessageBox.Show("Correct the errors");
        //  
        //    
        //}
        private void txtline_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsClassExists(string num)
        {
            Console.WriteLine(num);
            var cls = db.ClassTbl.ToList();
            if (cls.Count(x => x.ClassName.Trim() == num)>0)
                return true;
            return false;
        }
        private void btnShowRows_Click(object sender, EventArgs e)
        {
            if (!IsClassExists(nupClassNum.Value.ToString()))
            {
                int r = 0, k = 0;
                for (int i = 1; i <= Convert.ToInt32(nupRows.Text); i++)
                {
                    Label l = new Label();
                    l.Text = ":מספר שולחנות לטור" + i;
                    l.Size = new Size(140, 28);
                    l.Location = new Point(188, 40 + k);
                    panelTables.Controls.Add(l);
                    NumericUpDown nup = new NumericUpDown();
                    nup.Minimum = 1;
                    nup.Maximum = 6;
                    nup.Location = new Point(188, 70 + r);
                    nup.Name = i.ToString();
                    panelTables.Controls.Add(nup);
                    r += 50;
                    k += 50;
                }
                Button b = new Button();
                b.Size = new Size(140, 30);
                b.Text = "to finish";
                b.Location = new Point(44, 320);
                b.Click += keyclick;
                panelTables.Controls.Add(b);
            }
            else
            {
                MessageBox.Show("there is already class called " + nupClassNum.Value);
                nupClassNum.Value=1;
            }
        }
    }
}
