//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int LoginId { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
        public Nullable<int> Roleid { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
