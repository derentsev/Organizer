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
    using System.Collections.Generic;
    
    public partial class task_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public task_table()
        {
            this.team_table = new HashSet<team_table>();
            this.AspNetUsers = new HashSet<AspNetUser>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string TaskSubject { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int CreatorID { get; set; }
        public byte TaskPriority { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFinished { get; set; }
        public System.DateTime TaskCreationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team_table> team_table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
