//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Working_Hours
    {
        public int IdWorkingHours { get; set; }
        public string Day { get; set; }
        public System.DateTime Start_Time { get; set; }
        public System.DateTime End_Time { get; set; }
        public bool Is_NonWorking { get; set; }
        public int CompanyIdCompany { get; set; }
    
        public virtual Company Company { get; set; }
    }
}