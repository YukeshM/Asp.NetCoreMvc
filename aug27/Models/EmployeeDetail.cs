using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aug27.Models
{
    public class EmployeeDetail
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(25, ErrorMessage = "Name can not exceed 25 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(25, ErrorMessage = "Name can not exceed 25 characters")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Department Id is required")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]

        //[Required(ErrorMessage = "Skill Id is required")]
        //public int SkillId { get; set; }
        //[ForeignKey("SkillId")]

        public Department DepartmentForFK { get; set; }

        //public List<Skills> EmployeeSkills { get; set; }
    }
}
