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
    
    public partial class RegisterTest
    {
        public int ID { get; set; }
        public int Degree { get; set; }
        public bool Attend { get; set; }
        public bool IsEarly { get; set; }
        public int Student_Id { get; set; }
        public int Test_Id { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
    }
}