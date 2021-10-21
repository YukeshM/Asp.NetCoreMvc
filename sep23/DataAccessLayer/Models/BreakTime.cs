using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccessLayer.Models
{
    [Table("BreakTime")]
    public partial class BreakTime
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Entry Id is required")]
        public int EntryId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime BreakInTime { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime BreakOutTime { get; set; }

        [ForeignKey(nameof(EntryId))]
        [InverseProperty(nameof(EntryTime.BreakTimes))]
        public virtual EntryTime Entry { get; set; }
    }
}
