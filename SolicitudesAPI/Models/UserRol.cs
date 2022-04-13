using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class UserRol
    {
        public UserRol()
        {
            Users = new HashSet<User>();
        }

        public int UserRolId { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
