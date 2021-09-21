//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace aug27.Models
//{
//    public class Skills
//    {
//        [Key]
//        public int SkillId { get; set; }

//        [Required(ErrorMessage = "skill is required")]
//        [StringLength(25, ErrorMessage = "skill can not exceed 25 characters")]
//        public string SkillName { get; set; }

//        public EmployeeDetail employeeSkill { get; set; }
//    }
//}
