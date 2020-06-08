using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    [DisplayName("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Pick up day")]
        public DayOfWeek PickUpDay { get; set; }

        [Display(Name = "Extra pick up day")]
        public DateTime ExtraPickUp { get; set; }

        [Display(Name = "Payment Owed")]
        public int PaymentOwed { get; set; }

        [Display(Name = "Did you suspend your service?")]
        public DateTime ServiceSuspendedStart { get; set; }

        [Display(Name = "When your pickup suspension begins")]
        public DateTime ServiceSuspendEnd { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        public string Address { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
