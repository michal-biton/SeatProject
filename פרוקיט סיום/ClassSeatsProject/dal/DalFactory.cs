using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
   public static class DalFactory
    {
        public static IDAL GetDal(int type) 
        {
            switch (type)
            {
                case 1:return ClassMapDal.Instance;
                case 2:return  OracleDAl.Instance;
                default:
                    return null;
            }

        }
    }
}
