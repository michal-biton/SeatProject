using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace dal
{
   public class ClassMapDal : IDAL
    {
        static XDocument myDoc = XDocument.Load("XMLFile.xml");
        static XElement myRoot = myDoc.Root;
        public static ClassMapDal Instance { get; } = new ClassMapDal();
        ClassMapDal()
        {

        }
        public static void SaveInXml(int classCode, List<TableDal>[] classView)
        {
            XElement newClass = new XElement("class", new XAttribute("codeName", classCode));
            for (int i = 0; i < classView.Length; i++)
            {
                XElement newRow = new XElement("row", new XAttribute("numRow", i + 1));
                for (int j = 0; j < classView[i].Count(); j++)
                {
                    XElement newTable = new XElement("table", new XAttribute("numTable", j + 1));
                    int id = 0;
                    if (classView[i][j].tblCons != null)
                    {
                        foreach (var item in classView[i][j].tblCons)
                        {
                            XElement newConstraint = new XElement("constraint", new XAttribute("description", item.PropName), new XAttribute("id", id++));
                            newTable.Add(newConstraint);
                        }
                    }
                    newRow.Add(newTable);
                }
                newClass.Add(newRow);
            }
           
            myRoot.Add(newClass);
            myDoc.Save(@"XMLFile.xml");
        }
        public static int GetRowsNum(int codeClass)
        {
            bool flag = myRoot.Descendants("class").Any(x => x.Attribute("codeName").Value == codeClass.ToString());
            XElement cls;
            if (flag)
                cls = myRoot.Descendants("class").First(x => x.Attribute("codeName").Value == codeClass.ToString());
            else
                return -1;
            return cls.Descendants("row").Count();
        }
        public static int GetNumTablesForRow(int codeClass, int row)
        {
            return myRoot.Descendants("class").First(x => x.Attribute("codeName").Value == codeClass.ToString()).Descendants("row").First(x => x.Attribute("numRow").Value == row.ToString()).Descendants("table").Count();
        }
        public static List<PropertiesTbl> GetConsForTable(int codeClass,int row,int line)
        {
            List<PropertiesTbl> tblCons = new List<PropertiesTbl>();
            XElement table = myRoot.Descendants("class").First(x => x.Attribute("codeName").Value == codeClass.ToString()).Descendants("row").First(x => x.Attribute("numRow").Value == row.ToString()).Descendants("table").First(x => x.Attribute("numTable").Value == line.ToString());
            int numCons = table.Descendants("constraint").Count();
            if(numCons > 0)
            {
                for (int i = 0; i < numCons; i++)
                {
                   tblCons.Add(new PropertiesTbl() {PropName=table.Descendants("constraint").First(x=>x.Attribute("id").Value==i.ToString()).Attribute("description").Value});
                }
            }
            return tblCons;
        }
        public static bool IsExsistStudentPlacement(int codeClass)
        {
            XElement currentClass = myRoot.Descendants("class").First(x => x.Attribute("codeName").Value == codeClass.ToString());
            var students = currentClass.Descendants("student").ToList();
            return students.Count == 0 ? false : true;
        }
        public static void DeleteStudentsFromXML(int codeClass)
        {
            XElement currentClass = myRoot.Descendants("class").First(x => x.Attribute("codeName").Value == codeClass.ToString());
            currentClass.Descendants("student").Remove();
        }
        public static void AddStudentForTable(int codeClass, int row, int line, List<StudentTbl> studentList)
        {
            XElement table=myRoot.Descendants("class").First(x => x.Attribute("codeName").Value == codeClass.ToString()).Descendants("row").First(x => x.Attribute("numRow").Value == row.ToString()).Descendants("table").First(x => x.Attribute("numTable").Value == line.ToString());
            XElement newStudent = new XElement("student", new XAttribute("name", studentList[0]));
            table.Add(newStudent);
            newStudent = new XElement("student", new XAttribute("name", studentList[1]));
            table.Add(newStudent);
            myDoc.Save(@"XMLFile.xml");
        }
     
        public static void SaveInXML(int codeClass, int numRows, int[] arr)
        {
            XElement newClass = new XElement("class", new XAttribute("codeName", codeClass));
            for (int i = 0; i < numRows; i++)
            {
                XElement newRow = new XElement("row", new XAttribute("numRow", i + 1));
                for (int j = 0; j < arr[i]; j++)
                {
                    XElement newTable = new XElement("table", new XAttribute("numTable", j + 1));
                    newRow.Add(newTable);
                }
                newClass.Add(newRow);
            }
            myRoot.Add(newClass);
            myDoc.Save(@"XMLFile.xml");
        }
        public static bool CheckValidatePreferRowDal(int preferRow, int codeClass)
        {
            XElement currentClass = myRoot.Descendants("class").Single(x => Convert.ToInt32(x.Attribute("codeName").Value) == codeClass);
            var rows = currentClass.Descendants("row");
            int max = rows.Max(x => Convert.ToInt32(x.Descendants("table").Last().Attribute("numTable").Value));
            if (preferRow > max)
                return false;
            return true;
        }
        public static void DeleteStudentsFromXMLDal(int codeClass)
        {
            XElement currentClass = myRoot.Descendants("class").Single(x => Convert.ToInt32(x.Attribute("codeName").Value) == codeClass);
            var students = currentClass.Descendants("student").ToList();
            foreach (var item in students)
                item.Remove();
        }

        public void Save(int classCode, List<TableDal>[] classView)
        {
            SaveInXml(classCode, classView);
        }
    }
}
