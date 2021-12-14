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
    public partial class ConstraintUpdateFRM : Form
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        private ConstraintToStudentTbl st1;
        private StudentTbl st;
        private bool flagadd;
        private bool flagupdate;
        public ConstraintUpdateFRM()
        {
            InitializeComponent();
            flagadd = false;
            flagupdate = false;
            btnok.Visible = false;
            var arrs = db.StudentTbl.ToArray();
            cmbiStudent.Items.AddRange(arrs);
            var arrp = db.PropertiesTbl.ToArray();
            cmbconstraint.Items.AddRange(arrp);
            // dgcu.DataSource = db.ConstraintToStudentTbl.ToList();
            FillDG();
            OpenButten();
            CloseControls();

        }
        public void FillDG()
        {
            dgcu.DataSource = db.ConstraintToStudentTbl.Select(x => new {
                מזהה = x.ConsId,
                תלמידה =
                db.StudentTbl.FirstOrDefault(z => z.StudentId == x.StudentId),
                אילוץ = db.PropertiesTbl.FirstOrDefault(z => z.PropId == x.PropId),
                כןאולא = x.Is
            })
                .OrderBy(x => x.מזהה).ToList();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CloseButten()//נועלת כפתורים 
        {
            btnUpdate.Enabled = false;
            btnNew.Enabled = false;
        }
        private void OpenButten()//פותחת אפשרות לכפתורים
        {
            btnUpdate.Enabled = true;
            btnNew.Enabled = true;
        }

        private void CloseControls()//נועלת פקדים 
        {
            txtid.Enabled = false;
            cmbiStudent.Enabled = false;
            cmbconstraint.Enabled = false;
            rb1.Enabled = false;
            rb2.Enabled = false;
        }
        private void OpenControls()//פותחת אפשרות לפקדים
        {
            txtid.Enabled = true;
            cmbiStudent.Enabled = true;
            cmbconstraint.Enabled = true;
            rb1.Enabled = true;
            rb2.Enabled = true;
        }
        public void ClearS()//מרוקנת את הטקסטים 
        {
            txtid.Text = "";
            cmbiStudent.Text = "";
            cmbconstraint.Text = "";
            rb1.Checked = false;
            rb2.Checked = false;
        }
        private bool SelectDg(DataGridView dg)//פעולת עזר אם נבחרה רשומה
        {
            return (dg.SelectedRows.Count >= 1);
        }
        public string Namestudent(ConstraintToStudentTbl s) 
        {
          st=db.StudentTbl.Find(s.StudentId);
            cmbiStudent.Tag = s.StudentId;
            return st.FirstName + " " + st.LastName;
        }
        private void Fill(ConstraintToStudentTbl s)//ממלאת עצם 
        {
            if (dgcu.SelectedRows.Count >= 1)
            {
                cmbiStudent.Text = Namestudent(s);
                cmbconstraint.Text = s.PropId.ToString();
                if(s.Is==true)
                rb1.Checked = true;
                else
                rb2.Checked = true;
            }
            else
            {
                cmbiStudent.Text = "";
                cmbconstraint.Text = "";
                rb1.Checked = false;
                rb2.Checked = false;
            }
        }

        private bool CreateField(ConstraintToStudentTbl s)//בדיקת תקינות
        {
            bool x = true;
            errorProvider1.Clear();
            try
            {
                //Console.WriteLine(cmbid.SelectedItem.ToString().Replace(" ", ""));
                //Console.WriteLine(db.StudentTbl.First().ToString().Replace(" ", ""));
                s.StudentId = ((StudentTbl)cmbiStudent.SelectedItem).StudentId; 
                //db.StudentTbl.First(z => z.FirstName+z.LastName.Replace(" ", "") == cmbiStudent.SelectedItem.ToString().Replace(" ", "")).StudentId;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbiStudent, ex.Message);
                x = false;
            }
            try
            {
                s.PropId =((PropertiesTbl)cmbconstraint.SelectedItem).PropId;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbconstraint, ex.Message);
                x = false;
            }
            try
            {
                if (rb1.Checked)
                    s.Is = true;
                else
                    s.Is = false;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(rb1, ex.Message);
                errorProvider1.SetError(rb2, ex.Message);
                x = false;
            }

            return x;
        }

        private void BuChadash_Click(object sender, EventArgs e)
        {
            CloseButten();
            ClearS();
            flagadd = true;
            btnok.Visible = true;
            btnok.Enabled = true;
            txtid.Enabled = false;
            OpenControls();
            int max = 0;
            if (db.ConstraintToStudentTbl.Count() > 0)
                max = db.ConstraintToStudentTbl.Max(x => x.ConsId);
            txtid.Text = (max + 1).ToString();
            txtid.Enabled = false;
        }

        private void BuHidcun_Click(object sender, EventArgs e)
        {
            {
                btnok.Visible = true;
                if (SelectDg(dgcu))
                {
                    string x = dgcu.SelectedRows[0].Cells[0].Value.ToString();
                    int z = Convert.ToInt32(x);
                    st1 = db.ConstraintToStudentTbl.Find(z);
                    CloseButten();
                    flagupdate = true;
                    Fill(st1);
                }
                else
                    MessageBox.Show("כדי לעדכן נא בחרי רשומה");
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            ConstraintToStudentTbl cts = new ConstraintToStudentTbl();
            if (flagadd)
            {
                if (CreateField(cts))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף רשומה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {  
                        db.ConstraintToStudentTbl.Add(cts);
                        db.SaveChanges();
                        FillDG();
                    db.SaveChanges();
                        OpenButten();
                        ClearS();
                        btnok.Enabled = false;
                        CloseControls();
                    }
                }
                if (flagupdate)
                {
                    if (CreateField(cts))
                    {
                        DialogResult r = MessageBox.Show("האם לעדכן רשומה זו?", "אישור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(txtid.Text);
                            st1 = db.ConstraintToStudentTbl.First(x => x.ConsId == id);
                            st1.StudentId = ((StudentTbl)cmbiStudent.SelectedItem).StudentId;
                            st1.PropId = ((PropertiesTbl)cmbconstraint.SelectedItem).PropId;
                            if (rb1.Checked)
                                st1.Is = true;
                            else
                                st1.Is = false;
                            dgcu.DataSource = db.ConstraintToStudentTbl.Select(x =>
                                     new
                                     {
                                         מזהה = x.ConsId,
                                         תלמידה = x.StudentId,
                                         אילוץ = x.PropId,
                                         כןאולא = x.Is
                                     }).OrderBy(x => x.מזהה).ToList();
                       db.SaveChanges();
                            OpenButten();
                            ClearS();
                            txtid.Enabled = false;
                        }
                    }
                }
            }
        }
        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbid.SelectedItem == null)
            //{
            //    var lst = db.ConstraintToStudentTbl.Where(p => p.StudentId == 
            //    ((StudentTbl)cmbid.SelectedItem).StudentId).Select(x =>
            //     new{ מזהה = x.ConsId, תלמידה = x.StudentId,אילוץ = x.PropId,
            //  כןאולא = x.Is}).OrderBy(x => x.מזהה).ToList();
            //    dgcu.DataSource = lst;
            //}
            //else
            //{
            //    var lst = db.ConstraintToStudentTbl.Where(p => p.StudentId == 
            //    ((StudentTbl)cmbid.SelectedItem).StudentId && p.PropId == 
            //    ((PropertiesTbl)cmbconstraint.SelectedItem).PropId).Select(x =>new{ מזהה = 
            //    x.ConsId, תלמידה = x.StudentId,אילוץ = x.PropId, כןאולא = x.Is})
            //    .OrderBy(x => x.מזהה).ToList();
            //    dgcu.DataSource = lst;
            //}
        }

        private void cmbconstraint_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbconstraint.SelectedItem == null)
            //{
            //    var lst = db.ConstraintToStudentTbl.Where(p => p.PropId == ((PropertiesTbl)cmbconstraint.SelectedItem).PropId).Select(x =>
            //                      new
            //                      {
            //                          מזהה = x.ConsId,
            //                          תלמידה = x.StudentId,
            //                          אילוץ = x.PropId,
            //                          כןאולא = x.Is
            //                      }).OrderBy(x => x.מזהה).ToList();
            //    dgcu.DataSource = lst;
            //}
            //else
            //{
            //    var lst = db.ConstraintToStudentTbl.Where(p => p.StudentId == ((StudentTbl)cmbid.SelectedItem).StudentId && p.PropId == ((PropertiesTbl)cmbconstraint.SelectedItem).PropId).Select(x =>
            //                      new
            //                      {
            //                          מזהה = x.ConsId,
            //                          תלמידה = x.StudentId,
            //                          אילוץ = x.PropId,
            //                          כןאולא = x.Is
            //                      }).OrderBy(x => x.מזהה).ToList();
            //    dgcu.DataSource = lst;
            //}
        }
      

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConstraintUpdateFRM_Load(object sender, EventArgs e)
        {

        }
    }
}
