//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace school_management_crud
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int ID { get; set; }
        public Nullable<double> ScoreNumber { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<int> ScoreTypeID { get; set; }
    
        public virtual ScoreType ScoreType { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
