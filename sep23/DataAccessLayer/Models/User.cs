using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccessLayer.Models
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            EntryTimes = new HashSet<EntryTime>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty(nameof(EntryTime.User))]
        public virtual ICollection<EntryTime> EntryTimes { get; set; }
    }
}
