using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bll;
using System.Drawing.Text;
using dal;

namespace ClassSeatsProject
{
    public delegate void EventHandler(object sender, EventArgs e);//שלב 1 ביצירת דליגיט
    public partial class DeskUserControl : UserControl
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        public event EventHandler RemoveListBox;//שלב 2 ביצירת דליגייט
        static List<StudentTbl> students;
        public int row;
        public int line;
        public StudentTbl student1;
        public StudentTbl student2;
        public StudentTbl prevStudent1;
        public StudentTbl prevStudent2;
        public PlacementStudent ps1 = new PlacementStudent();
        public PlacementStudent ps2 = new PlacementStudent();
        public List<PropertiesTbl> tblCons=new List<PropertiesTbl>();
        public delegate void EventHandler(StudentTbl s,object sender);
        public event EventHandler remove;
        public event EventHandler add;
        public delegate void EventHandler1(Object sender, DragEventArgs e);
        public event EventHandler1 dStudent;
        public DeskUserControl(List<StudentTbl> studentsList)
        {

            InitializeComponent();
            cmb_st1.Items.AddRange(studentsList.ToArray());
            cmb_st2.Items.AddRange(studentsList.ToArray());
            lblResult.Width = 50;
            lblResult.Height = 50;
            lblResult.Text = "⏳";
            students = studentsList;
        }

        private void DeskUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void cmb_st1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_st2.SelectedItem != null)
                btn_check.Enabled = true;
            this.student1 = ((StudentTbl) cmb_st1.SelectedItem);
            remove?.Invoke(student1,sender);
          
            if (prevStudent1 != null)
            {
                if (CheckIfToAdd(prevStudent1))
                    add?.Invoke(prevStudent1, sender);//שלב 3 ביצירת דליגייט
            }
            prevStudent1 = student1;
            ps1.student = student1;
            ps1.UpdateConsToStudent();
            if (ps1.CheckSeat((int)this.line + 1) == SeatMark.Impossible )
            {
                string message = "שורה אינה מומלצת ל  " + student1;
                errorProvider1.SetError(cmb_st1, message);
            }
            if (!ps1.CheckConstraints(this.tblCons))
            {
                string message = "התנגשות אילוצי שלחן ל" + student1;
                errorProvider1.SetError(cmb_st1, message);

            }
            try
            {
                string s1 = ps1.student.PathImage;
                if (s1 != null && s1.StartsWith(@"\..\..\..\Images\"))
                {
                    Bitmap image1 = new Bitmap(Environment.CurrentDirectory + @"{0}" + s1);
                    ((PictureBox)pb1).BackgroundImage = (Image)image1;
                    pb1.BackgroundImageLayout = ImageLayout.Zoom;
                }
                if (cmb_st2.SelectedItem == null)
                    cmb_st2.Items.Remove(student1);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Data.ToString());
            }
        }
        public bool CheckIfToAdd(StudentTbl s)
        {
            if (students.Contains(s))
                return false;
            return true;
        }
        private void Checktable(PlacementTable pct)
        {
            if (pct != null)
            {
                SeatMark mark = pct.Check();
                switch (mark)
                {
                    case SeatMark.Excellent:
                        lblResult.Text = "😊";
                        lblResult.ForeColor = Color.Green;
                        MessageBox.Show(" מצוין!!! רמת הפטפוט של התלמידות נמוכה מהממוצע");

                        break;
                    case SeatMark.Possible:
                        lblResult.Text = "😐";
                        lblResult.ForeColor = Color.Orange;
                        MessageBox.Show("רמת הפטפוט של התלמידות גבוהה מהממוצע");
                        break;
                    case SeatMark.Impossible:
                        lblResult.Text = "😩";
                        lblResult.ForeColor = Color.Red;
                        MessageBox.Show(" רמת הפטפוט של התלמידות גבוהה בהרבה מהממוצע");
                        break;
                    default:
                        break;
                }
                this.Controls.Add(lblResult);
            }
        }
        private void btn_check_Click(object sender, EventArgs e)
        {
           
                PlacementTable pct = new PlacementTable(student1, student2);
                Checktable(pct);

        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_st2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_st1.SelectedItem != null)
                btn_check.Enabled = true;
            if (prevStudent2 != null)
            {
                if (CheckIfToAdd(prevStudent2))
                    add?.Invoke(prevStudent2,  sender);//שלב 3 ביצירת דליגייט
            }
            prevStudent2 = student2;
            this.student2 = ((StudentTbl)cmb_st2.SelectedItem);
            remove?.Invoke(student2, sender);
            ps2.student = student2;
            ps2.UpdateConsToStudent();
            if (!ps2.CheckConstraints(this.tblCons))
            {
                string message = "התנגשות אילוצי שלחן ל" + student2;
             
                errorProvider1.SetError(cmb_st2, message);
            }
            if ( ps2.CheckSeat((int)this.line + 1) == SeatMark.Impossible)
            {
                string message = "שורה אינה מומלצת ל  " + student2;
       
                errorProvider1.SetError(cmb_st2, message);
            }
                if (cmb_st1.SelectedItem == null)
                    cmb_st1.Items.Remove(student2);
            try
            {
                string s2 = ps2.student.PathImage;
                if (s2 != null && s2.StartsWith(@"\..\..\..\Images\"))
                {
                    Bitmap image2 = new Bitmap(Environment.CurrentDirectory + @"{0}" + s2);
                    ((PictureBox)pb2).BackgroundImage = (Image)image2;
                    pb2.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Data.ToString());
            }
            }
      

        private void lblResult_Click(object sender, EventArgs e)
        {
            if (student1 != null)
            {
                add?.Invoke(student1, sender);
                student1 = null;
                cmb_st1.Text = "";
                string s2 = @"\..\..\..\Images\2.png";
                Bitmap image2 = new Bitmap(Environment.CurrentDirectory + @"{0}" +s2);
                ((PictureBox)pb1).BackgroundImage = (Image)image2;
                pb1.BackgroundImageLayout = ImageLayout.Zoom;
                errorProvider1.SetError(cmb_st1, null);
            }
            if (student2 != null)
            {
                add?.Invoke(student2, sender);
                student2 = null;
                cmb_st2.Text = "";
                string s5 = @"\..\..\..\Images\5.png";
                Bitmap image2 = new Bitmap(Environment.CurrentDirectory + @"{0}" + s5);
                ((PictureBox)pb2).BackgroundImage = (Image)image2;
                pb2.BackgroundImageLayout = ImageLayout.Zoom;
                errorProvider1.SetError(cmb_st2, null);
            }
            lblResult.Text = "⏳";
            lblResult.ForeColor = Color.Black;
            btn_check.Enabled = false;
        }

        private void cmb_st1_DragDrop(object sender, DragEventArgs e)
        {
            RemoveListBox?.Invoke(student1, sender);//שלב 3 ביצירת דליגייט
        }

        private void cmb_st2_DragDrop(object sender, DragEventArgs e)
        {
            RemoveListBox?.Invoke(student2, sender);//שלב 3 ביצירת דליגייט
        }
        public override string ToString()
        {
            string str = "";
            foreach (var item in this.tblCons)
                str += item.ToString() + "\n";
            return str;
        }
        private void DeskUserControl_MouseHover(object sender, EventArgs e)
        {
          
                toolTip1.SetToolTip(this,"אילוצי השלחן:"+"\n" +this.ToString());
            
        }

    

        private void cmb_st1_DragDrop_1(object sender, DragEventArgs e)
        {
            dStudent?.Invoke(sender, e);
        }

        private void cmb_st1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void cmb_st2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void cmb_st2_DragDrop_1(object sender, DragEventArgs e)
        {
            dStudent?.Invoke(sender, e);
        }

        private void DeskUserControl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void DeskUserControl_HelpRequested_1(object sender, HelpEventArgs hlpevent)
        {
            string str = "תלמידות היכולות לשבת בשלחן זה:" + "\n";
            int count = 0;
            foreach (var item in students)
            {
                ps1 = new PlacementStudent();
                ps1.student = item;
                ps1.UpdateConsToStudent();
                if (ps1.CheckConstraints(this.tblCons) && ps1.CheckSeat((int)this.line + 1) == SeatMark.Impossible)
                {
                    count++;
                    str += item + "\n";
                }
            }
            if (count==0)
                str = "אין תלמידות היכולות לשבת בשלחן זה";
            toolTip1.SetToolTip(this, str);
        }
        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "ריקון שלחן");
        }
    }
}
