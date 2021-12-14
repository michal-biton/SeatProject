using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Windows.Forms;

namespace bll
{
    [Flags]
   
    public enum SeatMark {Excellent, Possible, Impossible }
    public class PlacementStudent
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        public StudentTbl student { get; set; }
        public List<ConstraintToStudentTbl> stCons;
        public PlacementStudent() {
            

        }
       
        public void UpdateConsToStudent()
        {
            stCons = new List<ConstraintToStudentTbl>();
            stCons = db.ConstraintToStudentTbl.Where(x => x.StudentId == student.StudentId).ToList();
        }
        public bool CheckConstraints(List<PropertiesTbl> tblCons)
        
        {
            var constNot = stCons.Where(x => x.Is == false).ToList();
            foreach(var conS in constNot)
            {
                foreach(var conT in tblCons)
                {
                    if (conT.PropName == db.PropertiesTbl.FirstOrDefault(x => x.PropId == conS.PropId).PropName)
                        return false;
                }
            }
            var constYes = stCons.Where(x => x.Is == true).ToList();
            foreach (var conS in constYes)
            {
                if (tblCons.Find(x => x.PropName == db.PropertiesTbl.FirstOrDefault(z => z.PropId == conS.PropId).PropName) == null)
                    return false;
            }
            return true;
           
        }
        public SeatMark CheckSeat(int line)
        {
            if (student.LineRecomended != null)
            {
                int def = Math.Abs((int)student.LineRecomended - line);
                if (def == 0)
                    return SeatMark.Excellent;
                if (def == 1)
                    return SeatMark.Possible;
                return SeatMark.Impossible;
            }
            return SeatMark.Possible;
           
        }

    }
}
