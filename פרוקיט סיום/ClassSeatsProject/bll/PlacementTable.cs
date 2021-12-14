using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
//using System.Data.Linq;
using System.Xml.Linq;



namespace bll
{
    public class PlacementTable
    {
        RuthProjectEntities db = RuthProjectEntities.Instance();
        StudentTbl student1;
        StudentTbl student2;
        public PlacementTable(StudentTbl s1, StudentTbl s2)
        {
            this.student1 = s1;
            this.student2 = s2;
        }
        public SeatMark Check()
        {
            int sumChatRate =(int) (student1.ChatRate + student2.ChatRate);
            if (sumChatRate < 5)
                return SeatMark.Excellent;
            if(sumChatRate < 7)
                return SeatMark.Possible;
            return SeatMark.Impossible;
        }
    }
}
