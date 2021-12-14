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
using System.Xml.Linq;
using bll;
using Microsoft.VisualBasic;
using OpenQA.Selenium.Interactions;

namespace ClassSeatsProject
{
    public partial class MapSettingFrm : Form
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        ClassMap map;
        private int classNum;
        private int Type;
        private int numRows;
        private List<int> tables;
        public MapSettingFrm()
        {
            InitializeComponent();
        }
        public MapSettingFrm(int className, int rowsNum, List<int> numTablesForRow)
        {
            InitializeComponent();
           
            this.classNum = className;
            this.numRows = rowsNum;
            this.tables = numTablesForRow;
            AddDesks();
        }
        private void AddDesks()
        {
            int c = 0, r = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < tables[i]; j++)
                {
                    DeskConstraintsUserControl d = new DeskConstraintsUserControl();
                    d.Name = "r" + i + "t" + j;
                    d.Location = new Point(1500 - c, 50 + r);
                    this.Controls.Add(d);
                    r += 150;
                }
                r = 0;
                c += 350;
            }
        }
        public void CreateMyForm()
        {
            Form form1 = new Form();
            Button button1 = new Button();
            Button button2 = new Button();
            button1.Text = "To_Xml";
            button1.Location = new Point(25, 10);
            button2.Text = "To_Oracel";
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 15);
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            form1.Text = "What Data base do you want";
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.AcceptButton = button1;
            form1.CancelButton = button2;
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Size = new Size(320, 130);
            form1.Controls.Add(button1);
            form1.Controls.Add(button2);
            form1.ShowDialog();
            if (form1.DialogResult == DialogResult.OK)
            {
                Type = 1;
                form1.Dispose();
            }
            else 
            {
                Type = 2;
                form1.Dispose();
            }
            if (Type != 1 && Type != 2)
                MessageBox.Show("pleas chose data base type");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateMyForm();
            Save(Type);
            ClassTbl c = new ClassTbl() { ClassName = classNum.ToString() };
            db.ClassTbl.Add(c);
            db.SaveChanges();
        }
       
        public List< PropertiesTbl> GetConsForTable(int row,int line)
        {
            List<PropertiesTbl> tblProp=null;
            foreach (var desk in this.Controls)
            {
                
                if(desk is DeskConstraintsUserControl&&(desk as DeskConstraintsUserControl).Name=="r"+row.ToString()+"t"+line.ToString())
                {
                   tblProp = new List<PropertiesTbl>();
                    foreach (var cb in (desk as DeskConstraintsUserControl).Controls)
                    {
                        if ((cb as CheckBox).Checked == true)
                        {
                            tblProp.Add(new PropertiesTbl { PropName = (cb as CheckBox).Text });  
                        }
                    }
                    break;
                }

            }
            return tblProp;
        }
        public void Save(int type)
        {
            map = new ClassMap(this.classNum);
            map.UpdateClassMapFromFrm(this.numRows);
            int count = 0;
            foreach (var item in tables)
            {
                map.classView[count] = new List<Table>();
                for (int i = 0; i < tables[count]; i++)
                {
                    map.classView[count].Add(new Table { Row = count + 1, Line = i + 1, tblCons = GetConsForTable(count + 1, i + 1) });
                }
                count++;
            }
            map.Save(type);
            this.Hide();
        }

        private void MapSettingFrm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            SettingsFRM f = new SettingsFRM();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MapSettingFrm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
