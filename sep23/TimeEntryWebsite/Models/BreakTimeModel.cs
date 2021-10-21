using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryWebsite.Models
{
    public class BreakTimeModel
    {
        [Key]
        public int Id
        {
            get; set;
        }

        [Required(ErrorMessage = "Break In time is required!")]
        [Display(Name = "Enter your break in time: ")]
        [DataType(DataType.DateTime, ErrorMessage =
           "BreakIntime and date required.")]
        public DateTime BreakInTime
        {
            get; set;
        }

        [Required(ErrorMessage = "Break out time is required!")]
        [Display(Name = "Enter you break out time: ")]
        [DataType(DataType.DateTime, ErrorMessage =
            "BreakOutTime and date required.")]
        public DateTime BreakOutTime
        {
            get; set;
        }

        //Foreign Key
        //public int EntryId
        //{
        //    get; set;
        //}

        //[ForeignKey("EntryId")]
        //public EntryTimeViewModel EntryForeignKey
        //{
        //    get; set;
        //}
    }
}
