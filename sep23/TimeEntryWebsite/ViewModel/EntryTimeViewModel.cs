using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryWebsite.ViewModel
{
    public class EntryTimeViewModel
    {
        [Key]
        public int Id
        {
            get; set;
        }

        [Required(ErrorMessage = "Name is required!")]
        [Display(Name="Enter your name: ")]
        public string Name
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
            "In time and date required.")]
        public DateTime OutTime
        {
            get; set;
        }

        [Required(ErrorMessage = "Break In time is required!")]
        [Display(Name = "Enter your break in time: ")]
        [DataType(DataType.DateTime, ErrorMessage = 
            "In time and date required.")]
        public DateTime BreakInTime
        {
            get; set;
        }

        [Required(ErrorMessage = "Break out time is required!")]
        [Display(Name = "Enter you break out time: ")]
        [DataType(DataType.DateTime, ErrorMessage = 
            "In time and date required.")]
        public DateTime BreakOutTime
        {
            get; set;
        }

    }
}
