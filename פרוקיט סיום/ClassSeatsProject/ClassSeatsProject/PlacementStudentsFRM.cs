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

namespace ClassSeatsProject
{
    public partial class PlacementStudentsFRM : Form
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        public int CodeClass { get; set; }
        List<StudentTbl> studentsList;
        ClassMap map;
        static XDocument myDoc = XDocument.Load("XMLFile.xml");
        static XElement myRoot = myDoc.Root;
        public PlacementStudentsFRM()
        {
            InitializeComponent();
            cmbClass.Items.AddRange(db.ClassTbl.ToArray());
            pteacher.Visible = false;
        }
        private void DragDrop1(Object sender, DragEventArgs e)
        {
            StudentTbl sDragged = e.Data.GetData(typeof(StudentTbl)) as StudentTbl;
            (sender as ComboBox).SelectedItem = sDragged;
        }
        public void RefreshStudents(object sender)
        {

            foreach (var item in panelClass.Controls)
            {

                foreach (var cb in (item as DeskUserControl).Controls)
                {
                    if (cb is ComboBox && cb != sender)
                    {
                        (cb as ComboBox).Items.Clear();
                        (cb as ComboBox).Items.AddRange(studentsList.ToArray());
                    }
                }
            }

        }
        public void removeFromLB(StudentTbl sRemoveLB, object sender)
        {

            studentsList.Remove(sRemoveLB);
            this.students.Items.Clear();
            this.students.Items.AddRange(studentsList.ToArray());
            RefreshStudents(sender);
        }

        public void AddToLB(StudentTbl sAddLB, object sender)
        {
            if (sAddLB != null)
            {
                studentsList.Add(sAddLB);
                this.students.Items.Clear();
                this.students.Items.AddRange(studentsList.ToArray());
                RefreshStudents(sender);
            }
        }
        private void AddDesks()
        {
            int c = 0, r = 0;
            var cls = myRoot.Descendants("class").Where(x => Convert.ToInt32(x.Attribute("codeName").Value) == CodeClass).FirstOrDefault();
            int numTables;
            int numRows = cls.Descendants("row").Count();
            for (int i = 0; i < numRows; i++)
            {
                numTables = cls.Descendants("row").Where(x => Convert.ToInt32(x.Attribute("numRow").Value) == i + 1).Descendants("table").Count();
                for (int j = 0; j < numTables; j++)
                {
                    DeskUserControl d = new DeskUserControl(studentsList);
                    var cons = cls.Descendants("row").Where(x => Convert.ToInt32(x.Attribute("numRow").Value) == i + 1).Descendants("table").Where(x => Convert.ToInt32(x.Attribute("numTable").Value) == j + 1).Descendants("constraint").Select(x => new { x.Attribute("description").Value }).ToList();
                    foreach (var item in cons)
                    {
                        d.tblCons.Add(new PropertiesTbl { PropName = item.ToString() });
                    }
                    d.row = i + 1;
                    d.line = j + 1;
                    d.Location = new Point(800 - c, 50 + r);
                    d.remove += (this.removeFromLB);
                    d.add += (this.AddToLB);
                    d.dStudent += (this.DragDrop1);
                    panelClass.Controls.Add(d);
                    r += 150;
                }
                r = 0;
                c += 350;
            }
        }
        private void PlacementStudents2FRM_Load(object sender, EventArgs e)
        {

        }

        private void PlacementStudents2FRM_Load_1(object sender, EventArgs e)
        {

        }

        private void panelClass_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.students.Items.Clear();
            pteacher.Visible = true;
            panelClass.Controls.Clear();
            this.CodeClass = Convert.ToInt32(cmbClass.SelectedItem.ToString());
            map = new ClassMap(this.CodeClass);
            bool isEmptyClass = map.UpdateClassMapFromXml();
            if (isEmptyClass)
                MessageBox.Show("כיתה זו ריקה אנא בחר כיתה אחרת");
            else
            {
                studentsList = db.StudentTbl.Where(x => x.Grade == CodeClass).ToList();
                students.Items.AddRange(studentsList.ToArray());
                AddDesks();
            }
        }
        private void students_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void students_MouseDown(object sender, MouseEventArgs e)
        {
            DataObject obj = new DataObject(typeof(StudentTbl).FullName, (sender as ListBox).SelectedItem);
            students.DoDragDrop(obj, DragDropEffects.Copy);
        }
        private void HelpTeacher(object sender, EventArgs e)
        {
            DeskUserControl d;
            foreach (var table in panelClass.Controls)
            {
                d = (table as DeskUserControl);
                d.ps1.student = (StudentTbl)((sender as ComboBox).SelectedItem);
                d.ps1.UpdateConsToStudent();
                if (d.ps1.CheckSeat((int)(table as DeskUserControl).line + 1) != SeatMark.Impossible && d.ps1.CheckConstraints((table as DeskUserControl).tblCons))
                    d.BackColor = Color.Green;
            }
        }
        private void PlacementStudentsFRM_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            ComboBox cmbHelpTeacher = new ComboBox();
            cmbHelpTeacher.Location = new Point(1700, 622);
            cmbHelpTeacher.Size = new Size(120, 21);
            cmbHelpTeacher.Items.AddRange(db.StudentTbl.Where(x => x.Grade == CodeClass).ToArray());
            cmbHelpTeacher.SelectedIndexChanged += HelpTeacher;
            this.Controls.Add(cmbHelpTeacher);
        }

        private void cbteacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string S2 = "";
            switch (cbteacher.Text)
            {
                case "המורה צופיה":
                    S2 = @"\..\..\..\Images\zofia.JPG";
                    break;
                case "המורה אלינסון":
                    S2 = @"\..\..\..\Images\bracha.JPG";
                    break;
                case "המורה אדלשטין":
                    S2 = @"\..\..\..\Images\edelshtein.JPG";
                    break;
                case "המורה גילה לוי":
                    S2 = @"\..\..\..\Images\gila.JPG";
                    break;
                default:
                    break;
            }

            if (S2 != "")
            {
                Bitmap image1 = new Bitmap(Environment.CurrentDirectory + @"{0}" + S2);
                ((PictureBox)Pbteacher).BackgroundImage = (Image)image1;
                PictureBox imaage = new PictureBox();
                imaage.Width = 103;
                imaage.Height = 96;
                Pbteacher.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SavePlacement()
        {
            foreach (var desk in panelClass.Controls)
            {
                List<StudentTbl> studentsListForTable = new List<StudentTbl>();
                studentsListForTable.Add((desk as DeskUserControl).student1);
                studentsListForTable.Add((desk as DeskUserControl).student2);
                map.AddStudentForTableInXml((desk as DeskUserControl).row, (desk as DeskUserControl).line, studentsListForTable);
                UpdatePlacementForStudents(desk as DeskUserControl);

            }
            MessageBox.Show("השיבוץ נשמר בהצלחה");
            panelClass.Controls.Clear();
        }

        private void UpdatePlacementForStudents(DeskUserControl desk)
        {

            desk.student1.Row = desk.row;
            desk.student1.Line = desk.line;
            desk.student2.Row = desk.row;
            desk.student2.Line = desk.line;
            db.SaveChanges();
        }
        private void btnsaveP_Click(object sender, EventArgs e)
        {
            if (students.Items.Count == 0)
            {
                if (map.IsExsistStudentPlacement())
                {
                    DialogResult r = MessageBox.Show("שיבצת בעבר כיתה זו, האם תרצי לבצע שיבוץ חדש?", "הערה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        map.DeleteStudentsFromXML();
                        SavePlacement();
                    }
                }
                else
                    SavePlacement();
            }
            else
                MessageBox.Show("ישנן תלמידות לא משובצות", "הערה", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}
