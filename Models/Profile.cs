using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryManagement.Models
{
    public partial class Profile
    {
        public string Name { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfrimPassword { get; set; }
    }
}
