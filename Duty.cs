//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STDApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Duty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Duty()
        {
            this.Student_Duty = new HashSet<Student_Duty>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Expire { get; set; }
        public int Subject_Id { get; set; }
        public int Department_Id { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Subject Subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Duty> Student_Duty { get; set; }
    }
}
