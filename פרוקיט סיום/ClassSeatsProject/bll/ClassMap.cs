using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using Microsoft.VisualBasic;

namespace bll
{
    public class ClassMap
    {
        public int ClassNum { get; set; }
        private int rowsNum;
        public List<Table>[] classView;
        public ClassMap(int ClassNum)
        {
            this.ClassNum = ClassNum; 
        }
        public void UpdateClassMapFromFrm(int rows)
        {
            this.rowsNum = rows;
            classView = new List<Table>[rowsNum];

        }
        public List<TableDal> GetListTableDal(List<Table> tables)
        {
            List<TableDal> l = new List<TableDal>();
            foreach(var item in tables )
            {
                l.Add(item.FromTableToTableDal());
            }
            return l;
        }
        public List<TableDal>[] GetArrListTableDal()
        {
            List<TableDal>[] l= new List<TableDal>[rowsNum];
            for (int i = 0; i < rowsNum; i++)
            {
                l[i] = this.GetListTableDal(this.classView[i]);
            }
            return l;
        }
        public void Save(int type)
        {
            IDAL dal = DalFactory.GetDal(type);
            dal.Save(this.ClassNum, GetArrListTableDal());
        }
        public bool UpdateClassMapFromXml()
        {
            this.rowsNum = ClassMapDal.GetRowsNum(this.ClassNum);
            if (this.rowsNum!=-1)
            {
                this.classView = new List<Table>[rowsNum];
                for (int i = 0; i < rowsNum; i++)
                {
                    classView[i] = new List<Table>();
                    for (int j = 0; j < ClassMapDal.GetNumTablesForRow(this.ClassNum, i + 1); j++)
                    {
                        classView[i].Add(new Table { Row = i + 1, Line = j + 1, tblCons = ClassMapDal.GetConsForTable(this.ClassNum, i + 1, j + 1) });
                    }
                }
                return false;
            }
            return true;
        }
        public bool IsExsistStudentPlacement()
        {
            return ClassMapDal.IsExsistStudentPlacement(this.ClassNum);
        }
        public void DeleteStudentsFromXML()
        {
            ClassMapDal.DeleteStudentsFromXML(this.ClassNum);
        }
        public void AddStudentForTableInXml(int row,int line,List<StudentTbl> studentList)
        {
            ClassMapDal.AddStudentForTable(this.ClassNum, row, line, studentList);
        }




    }
}
