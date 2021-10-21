using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryWebsite.Models
{
    public class EntryTimeModel
    {

        [Key]
        public int Id
        {
            get; set;
        }


        [Required(ErrorMessage = "In time is required!")]
        [Display(Name = "Enter your In time: ")]
        [DataType(DataType.DateTime, ErrorMessage =
            "In time and date required.")]
        public DateTime InTime
        {
            get; set;
        }

        [Required(ErrorMessage = "Out time is required!")]
        [Display(Name = "Enter your Out time: ")]
        [DataType(DataType.DateTime, ErrorMessage =
            "Out time and date required.")]
        public DateTime OutTime
        {
            get; set;
        }


        //foreign key
        [ForeignKey("User")]
        public string UserId
        {
            get; set;
        }

        public IdentityUser User
        {
            get; set;
        }
    }
}
