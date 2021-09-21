using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aug25Employee.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(25, ErrorMessage = "Name can not exceed 25 characters")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(25, ErrorMessage = "Name can not exceed 25 characters")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "DepartmentId is required")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]

        [Required(ErrorMessage = "date is required")]
        public DateTime HireDate { get; set; }
    }
}
