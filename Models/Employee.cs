using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Position { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Salary { get; set; }
        [Display(Name = "Date of Employment")]
        public DateTime Employment_Date { get; set; }
    }
}
