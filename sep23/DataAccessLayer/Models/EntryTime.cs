using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccessLayer.Models
{
    [Table("EntryTime")]
    public partial class EntryTime
    {
        public EntryTime()
        {
            BreakTimes = new HashSet<BreakTime>();
        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OutTime { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("EntryTimes")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(BreakTime.Entry))]
        public virtual ICollection<BreakTime> BreakTimes { get; set; }
    }
}
