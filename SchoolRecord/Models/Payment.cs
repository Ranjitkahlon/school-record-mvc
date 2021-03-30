using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRecord.Models
{
    public class Payment
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

      

        [Display(Name = "Fee")]
        public string Fee { get; set; }


        [Display(Name = "Payment Date")]
        public string PaymentDate { get; set; }
    }
}
