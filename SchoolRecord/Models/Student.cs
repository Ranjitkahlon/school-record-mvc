using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRecord.Models
{
    public class Student
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }


        [Display(Name = "Father Name")]
        public string FatherName { get; set; }


        [Display(Name = "Class")]
        public string Class { get; set; }

        [Display(Name = "Contact")]
        public string Contact { get; set; }

    }
}
