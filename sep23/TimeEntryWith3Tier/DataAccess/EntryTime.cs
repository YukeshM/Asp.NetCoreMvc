using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class EntryTime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public DateTime BreakInTime { get; set; }
        public DateTime BreakOutTime { get; set; }
    }
}
