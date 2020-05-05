//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagmentSystem.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    

    
    public partial class tbl_booking
    {

        public int booking_id { get; set; }
        [Display(Name="Customer Name")]
        public string customer_name { get; set; }

        [Display(Name ="Custome Address")]
        public string customer_address { get; set; }

        [Display(Name = "Custome Email")]
        public string customer_email { get; set; }

        [Display(Name = "Custome Phonne No")]
        public string customer_phone_no { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Booking From")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public System.DateTime booking_from { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Booking To")]
       
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]

        public System.DateTime booking_to { get; set; }

        [Display(Name = "Payment Types")]
       
        public int payment_type { get; set; }

        [Display(Name = "Assigned Room")]
       
        public int assigned_room { get; set; }

        [Display(Name = "No of Members")]
       
        public Nullable<byte> no_of_members { get; set; }

        [Display(Name = "Total Amount")]
       
        public Nullable<decimal> total_amount { get; set; }

        [Display(Name = "Rooms")]
      
        public virtual tbl_room tbl_room { get; set; }

        [Display(Name = "Payment Type")]
        
        public virtual tbl_payment_type tbl_payment_type { get; set; }
    }
}
