//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int id { get; set; }
        public int hostid { get; set; }
        public string loginaccess { get; set; }
        public System.DateTime Createdate { get; set; }
        public Nullable<System.DateTime> Expiredate { get; set; }
    
        public virtual Host Host { get; set; }
    }
}
