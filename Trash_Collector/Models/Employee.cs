using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Employee
    {

        [Key]
        //default view as a list of the day's pickups
        public int ZipCode { get; set; }

        //able to filter pickups by particular day

        public bool CompletedPickup { get; set; }

        //all pickups have a charge applied to the customer
        public int PickUpWithChargeApplied { get; set; }
        public int Id { get; internal set; }

        //select a customer profile and see their address pinned on a google map

    }
}
