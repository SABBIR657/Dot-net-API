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
    
    public partial class Booking
    {
        public int bookingid { get; set; }
        public int clientid { get; set; }
        public int packageid { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Package Package { get; set; }
    }
}
