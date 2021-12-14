using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class PartialClasses
    {
    }
    public partial class StudentTbl
    {
        public override string ToString()
        {
            return this.FirstName+" "+this.LastName;
        }

        public static List<string> Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
    public partial class ClassTbl
    {
        public override string ToString()
        {
            return this.ClassName;
        }
    }
    public partial class PropertiesTbl
    {
        public override string ToString()
        {
            return this.PropName.Replace("{ Value =","").Replace(" }", ""); 
           
        }
    }
}
