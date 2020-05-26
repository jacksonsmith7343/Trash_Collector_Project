using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Employee
    {

        [Key]
        
        public int ZipCode { get; set; }

        public bool CompletedPickup { get; set; }
        
        public int PickUpWithChargeApplied { get; set; }
        public int Id { get; internal set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        

    }
}
