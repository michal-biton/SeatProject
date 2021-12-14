using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
   public interface IDAL
    {
        void Save(int classCode, List<TableDal>[] classView);
    }
}
