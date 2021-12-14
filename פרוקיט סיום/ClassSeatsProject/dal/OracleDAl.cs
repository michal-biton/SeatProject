using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    class OracleDAl : IDAL
    {
        public static OracleDAl Instance { get; } = new OracleDAl();
        public void Save(int classCode, List<TableDal>[] classView)
        {
            throw new NotImplementedException();
        }
    }
}
