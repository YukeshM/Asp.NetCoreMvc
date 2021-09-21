using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginUsingIdentity.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string MultiCheck { get; set; }

        public string TextArea { get; set; }

        public string RadioButton { get; set; }

        public int Slider { get; set; }

        public int Star { get; set; }
    }
}
