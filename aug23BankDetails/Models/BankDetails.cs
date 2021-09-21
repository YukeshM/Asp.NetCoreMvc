using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aug23BankDetails.Models
{
    public class BankDetails
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(25, ErrorMessage = "Name can not exceed 25 characters")]
        public string  Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(25, ErrorMessage = "Adress can not exceed 75 characters")]
        public string Address { get; set; }

        public short Age { get; set; }
        public string Gender { get; set; }
        public double OpeningBalance { get; set; }
    }
}
