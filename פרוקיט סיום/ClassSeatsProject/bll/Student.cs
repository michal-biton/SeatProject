using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        protected List<Student> list = new List<Student>();
        public int ChatRate { 
            get
            {
                return this.ChatRate;
            }
            set
            {
                if (ChatRate<=5|| ChatRate>=1)
                    this.ChatRate = value;
                else
                    throw new Exception("רמת פטפוט יכולה להיות בין 1 ל5 בלבד");
            }
        }
        public int LineRecomended { get; set; }
        public int Row { get; set; }
        public int Line { get; set; }
        public Student() { }
        public Student(int StudentId) {
               this.StudentId = StudentId;
        }
        public Student(int StudentId, string FirstName,string LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

    }
}
