using bll;
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
    public partial class AddStudentFRM : Form
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        private StudentTbl st1;
        private bool flagadd;
        private bool flagupdate;
        public AddStudentFRM()
        {
            InitializeComponent();
            flagadd = false;
            flagupdate = false;
            btnok.Visible = false;
            btncancel.Visible = false;
            var arrc = db.ClassTbl.ToArray();
            cmbClass.Items.AddRange(arrc);
            dgstudent.DataSource = db.StudentTbl.Select(x =>new{
                מזהה = x.StudentId,
                שם_פרטי = x.FirstName,שם_משפחה = x.LastName,
            כיתה = x.Grade,דרגת_פטפוט = x.ChatRate,שורה_מומלצת = x.LineRecomended,
                תמונה = x.PathImage,שורה=x.Line,טור=x.Row
            }).OrderBy(x => x.שם_פרטי).ToList();
        }

        private void AddStudentFRM_Load(object sender, EventArgs e)
        {

        }
        private void Closebutten()//נועלת כפתורים 
        {
            btnUpdate.Enabled = false;
            btnNew.Enabled = false;
        }
        private void Openbutten()//פותחת אפשרות לכפתורים
        {
            btnUpdate.Enabled = true;
            btnNew.Enabled = true;
        }
        public void ClearS()//מרוקנת את הטקסטים 
        {
            txtid.Text = "";
            txtfname.Text = "";
            cmbClass.Text = "";
            txtlname.Text = "";
            txtimage.Text = "";
            NUDchat.Value = 1;
            NUDline.Value = 1;
        }
        private bool CreateField(StudentTbl s)//בדיקת תקינות
        {
            bool x = true;
            errorProvider1.Clear();
            try
            {
                s.FirstName = txtfname.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtfname, ex.Message);
                x = false;
            }
            try
            {
               s.LastName = txtlname.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtlname, ex.Message);
                x = false;
            }
            try
            {
                s.Grade = Convert.ToInt32(cmbClass.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbClass, ex.Message);
                x = false;
            }
            try
            {
                s.ChatRate = Convert.ToInt32(NUDchat.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(NUDchat, ex.Message);
                x = false;
            }
            try
            {
                s.LineRecomended = Convert.ToInt32(NUDline.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(NUDline, ex.Message);
                x = false;
            }
            try
            {
                s.PathImage = txtimage.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtimage, ex.Message);
                x = false;
            }
            return x;
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            StudentTbl s = new StudentTbl();
            if (flagadd)
            {
                if (CreateField(s))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף תלמידה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        StudentTbl news = new StudentTbl() { FirstName = txtfname.Text, LastName = txtlname.Text, Grade = Convert.ToInt32(cmbClass.Text), ChatRate = Convert.ToInt32(NUDchat.Value), LineRecomended = Convert.ToInt32(NUDline.Value) };
                        db.StudentTbl.Add(news);
                        db.SaveChanges();
                        Openbutten();
                        ClearS();
                        txtid.Enabled = false;
                        flagadd = false;
                        dgstudent.DataSource = db.StudentTbl.Select(x =>
                        new
                        {
                            מזהה = x.StudentId,
                            שם_פרטי = x.FirstName,
                            שם_משפחה = x.LastName,
                            כיתה = x.Grade,
                            דרגת_פטפוט = x.ChatRate,
                            שורה_מומלצת = x.LineRecomended,
                            תמונה = x.PathImage
                        }).OrderBy(x => x.שם_פרטי).ToList();
                    }
                }
            }
            if (flagupdate)
            {
                if (CreateField(s))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן תלמידה זו?", "אישור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(txtid.Text);
                        st1 = db.StudentTbl.First(x => x.StudentId == id);
                        st1.FirstName=txtfname.Text;
                        st1.LastName = txtlname.Text;
                        st1.Grade =Convert.ToInt32( cmbClass.Text);
                        st1.ChatRate = Convert.ToInt32(NUDchat.Value);
                        st1.LineRecomended = Convert.ToInt32(NUDline.Value);
                        st1.PathImage = txtimage.Text;
                       db.SaveChanges();
                        Openbutten();
                        ClearS();
                        flagupdate = false;
                        dgstudent.DataSource = db.StudentTbl.Select(x => 
                        new {
                            מזהה = x.StudentId,
                            שם_פרטי = x.FirstName, שם_משפחה = x.LastName,
                            כיתה = x.Grade, דרגת_פטפוט = x.ChatRate,
                            שורה_מומלצת = x.LineRecomended,
                            תמונה = x.PathImage
                        }).OrderBy(x => x.שם_פרטי).ToList();
                        txtid.Enabled = false;
                    }
                }
            }
        }
        private void BuChadash_Click(object sender, EventArgs e)
        {
            Closebutten();
            ClearS();

            txtid.Enabled = false;
            int max = db.StudentTbl.Max(x => x.StudentId);
            txtid.Text =( max+1).ToString();
            flagadd = true;
            btnok.Visible = true;
            btncancel.Visible = true;
        }
        private void Fill(StudentTbl s)//ממלאת עצם תלמידה
        {
            if (dgstudent.SelectedRows.Count >= 1)
            {
                txtid.Text =s.StudentId.ToString() ;
                txtfname.Text =s.FirstName ;
                cmbClass.Text =s.Grade.ToString() ;
                txtlname.Text = s.LastName;
                if(s.ChatRate>=1)
                NUDchat.Value = Convert.ToInt32(s.ChatRate);
                if (s.LineRecomended >= 1)
                    NUDline.Value = Convert.ToInt32(s.LineRecomended);
                txtimage.Text = s.PathImage;
            }
            else
            {
                txtfname.Text = "";
                cmbClass.Text = "";
                txtlname.Text = "";
                NUDchat.Value = 1;
                NUDline.Value = 1;
                txtimage.Text = "";
            }
        }
        private bool SelectDg(DataGridView dg)//פעולת עזר אם נבחרה רשומה
        {
            return (dg.SelectedRows.Count >= 1);
        }
        private void BuHidcun_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            btnok.Visible = true;
            btncancel.Visible = true;
            if (SelectDg(dgstudent))
            {
                int k = Convert.ToInt32(dgstudent.SelectedRows[0].Cells[0].Value);    
                st1 = db.StudentTbl.Find(k);
                Closebutten();
                flagupdate = true;
                Fill(st1);
            }
            else
                MessageBox.Show("כדי לעדכן נא בחרי תלמידה");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Openbutten();
            ClearS();
            txtid.Enabled = false;
            btnok.Visible = false;
            btncancel.Visible = false;
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            dgstudent.DataSource = db.StudentTbl.Where(x => x.FirstName.ToString().StartsWith(txtfname.Text)).Select(x =>
                        new {
                            מזהה = x.StudentId,
                            שם_פרטי = x.FirstName,
                            שם_משפחה = x.LastName,
                            כיתה = x.Grade,
                            דרגת_פטפוט = x.ChatRate,
                            שורה_מומלצת = x.LineRecomended,
                            תמונה = x.PathImage
                        }).OrderBy(x => x.שם_פרטי).ToList();

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {
            dgstudent.DataSource = db.StudentTbl.Where(x => 
            x.LastName.ToString().StartsWith(txtlname.Text)).
            Select(x =>
                       new {
                            מזהה = x.StudentId,
                           שם_פרטי = x.FirstName,
                           שם_משפחה = x.LastName,
                           כיתה = x.Grade,
                           דרגת_פטפוט = x.ChatRate,
                           שורה_מומלצת = x.LineRecomended,
                           תמונה = x.PathImage
                       }).OrderBy(x => x.שם_פרטי).ToList();
        }

        private void txtclass_TextChanged(object sender, EventArgs e)
        {
            dgstudent.DataSource = db.StudentTbl.Where(x =>
            x.Grade.ToString().StartsWith(cmbClass.Text))
                .Select(x =>
                         new {
                            מזהה = x.StudentId,
                             שם_פרטי = x.FirstName,
                             שם_משפחה = x.LastName,
                             כיתה = x.Grade,
                             דרגת_פטפוט = x.ChatRate,
                             שורה_מומלצת = x.LineRecomended,
                             תמונה = x.PathImage
                         }).OrderBy(x => x.שם_פרטי).ToList();
        }

        private void NUDchat_ValueChanged(object sender, EventArgs e)
        {
        }

        private void NUDline_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            dgstudent.DataSource = db.StudentTbl.Where(x => x.StudentId.ToString().StartsWith(txtid.Text)).Select(x =>
                       new {
                          מזהה = x.StudentId,
                           שם_פרטי = x.FirstName,
                           שם_משפחה = x.LastName,
                           כיתה = x.Grade,
                           דרגת_פטפוט = x.ChatRate,
                           שורה_מומלצת = x.LineRecomended,
                           תמונה = x.PathImage
                       }).OrderBy(x => x.שם_פרטי).ToList();
        }

        private void dgstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgstudent_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(dgstudent.SelectedRows[0].Cells[0].Value);
            st1 = db.StudentTbl.Find(k);
            DialogResult r = MessageBox.Show("האם למחוק תלמידה זו?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {   
                db.StudentTbl.Remove(st1);
                MessageBox.Show("התלמידה הוסרה בהצלחה");
                dgstudent.DataSource = db.StudentTbl.Select(x =>
                       new
                       {
                           מזהה = x.StudentId,
                           שם_פרטי = x.FirstName,
                           שם_משפחה = x.LastName,
                           כיתה = x.Grade,
                           דרגת_פטפוט = x.ChatRate,
                           שורה_מומלצת = x.LineRecomended,
                           תמונה = x.PathImage
                       }).OrderBy(x => x.שם_פרטי).ToList();
            }
        }
    }
}
