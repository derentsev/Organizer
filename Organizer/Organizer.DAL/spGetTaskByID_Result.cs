//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Organizer.DAL
{
    using System;
    
    public partial class spGetTaskByID_Result
    {
        public string TaskTitle { get; set; }
        public string TaskSubject { get; set; }
        public System.DateTime TaskStartDate { get; set; }
        public System.DateTime TaskEndDate { get; set; }
        public int TaskCreatorID { get; set; }
        public byte TaskPriority { get; set; }
        public bool TaskIsFinished { get; set; }
        public System.DateTime TaskCreationDate { get; set; }
    }
}
