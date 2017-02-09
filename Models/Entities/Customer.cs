//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScottybonsMVC.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.OrderShippings = new HashSet<OrderShipping>();
            this.ForgotPasswords = new HashSet<ForgotPassword>();
            this.OrderTransactions = new HashSet<OrderTransaction>();
            this.Orders = new HashSet<Order>();
        }
    
        public int CustomerID { get; set; }
        public int MemberId { get; set; }
        public int CustomerstatusID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrePosition { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int SaltKey { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternativePhoneNumber { get; set; }
        public string LocaleSetting { get; set; }
        public int Active { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual ICollection<OrderShipping> OrderShippings { get; set; }
        public virtual ICollection<ForgotPassword> ForgotPasswords { get; set; }
        public virtual ICollection<OrderTransaction> OrderTransactions { get; set; }
        public virtual PasswordLog PasswordLog { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}