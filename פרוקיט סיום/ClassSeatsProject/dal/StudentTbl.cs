//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentTbl()
        {
            this.ConstraintToStudentTbl = new HashSet<ConstraintToStudentTbl>();
        }
    
        public int StudentId { get; set; }
        private string firstName;
             public string FirstName
        {
            get { return firstName; }
            set { firstName = value.TrimEnd(); }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value.TrimEnd(); }
        }
        public Nullable<int> Grade { get; set; }
        public Nullable<int> ChatRate { get; set; }
        public Nullable<int> LineRecomended { get; set; }
        public Nullable<int> Row { get; set; }
        public Nullable<int> Line { get; set; }
      //  private string pathImage;
        public string PathImage { get; set; }
        //public string PathImage
        //{
        //    get { return pathImage; }
        //    set { pathImage = value.TrimEnd(); }
        //}

        public virtual ClassTbl ClassTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConstraintToStudentTbl> ConstraintToStudentTbl { get; set; }
    }
}
