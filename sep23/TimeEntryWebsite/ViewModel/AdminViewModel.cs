using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using TimeEntryWebsite.Models;

namespace TimeEntryWebsite.ViewModel
{
    public class AdminViewModel
    {

        public List<BreakTimeModel> breakTimeModels
        {
            get; set;
        }

        public List<EntryTimeModel> entryTimeModels
        {
            get; set;
        }

        public IdentityUser users
        {
            get;
            set;
        }

    }
}
//  public class NewViewModel
//  {
//    public int EntryId { get; set; }

//    public Date date { get; set; }

//    public TimeSpan InTime { get; set; }

//    public TimeSpan OutTIme { get; set; }

//    public List<BreakModel> breaks { get; set; }
//  }

//  public class TotalEnryList
//  {
//      public List<NewViewModel> ListOfEntry { get; set; }
//  }
//}
