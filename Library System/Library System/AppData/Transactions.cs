//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_System.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public string TransactionType { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public int StaffId { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Members Members { get; set; }
        public virtual Staffs Staffs { get; set; }
    }
}
