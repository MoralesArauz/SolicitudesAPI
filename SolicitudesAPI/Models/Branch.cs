using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Users = new HashSet<User>();
        }

        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
