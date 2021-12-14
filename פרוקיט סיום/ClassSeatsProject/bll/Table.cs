using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class Table
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        public int Row { get; set; }
        public int Line { get; set; }
        public List<PropertiesTbl> tblCons;
        //public List<StudentTbl> students;
        public Table()
        {
            tblCons = new List<PropertiesTbl>();
        }
        public TableDal FromTableToTableDal()
        {
            TableDal t = new TableDal() { Row = this.Row, Line = this.Line, tblCons = this.tblCons };
            return t;
        }
    }
}
