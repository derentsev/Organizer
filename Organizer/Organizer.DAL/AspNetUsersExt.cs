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
    
    public partial class AspNetUsersExt
    {
        public string UserId { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string SecurityAnswerSalt { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
