using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core_Crud_Mvc.Models
{
    public class NewEmpClass
    {
        [Key]
        public int Empid { get; set; }


        [Required(ErrorMessage ="Enter the name")]
        [Display(Name ="Employee Name")]
        public string Emplname { get; set; }

        [Required(ErrorMessage = "Enter the Email")]
        [Display(Name = "Employee Email")]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }

        [Required(ErrorMessage = "Enter the Age")]
        [Display(Name = "Employee Age")]
        [Range(20,60)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter the Salary")]
        [Display(Name = "Employee salary")]
        public int Salary { get; set; }


    }
}
