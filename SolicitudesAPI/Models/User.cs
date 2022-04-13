using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class User
    {
        public User()
        {
            PurchaseOrderApplicants = new HashSet<PurchaseOrder>();
            PurchaseOrderBuyers = new HashSet<PurchaseOrder>();
        }

        public int UserId { get; set; }
        public string IdentificationCard { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string BranchId { get; set; }
        public int UserRolId { get; set; }
        public bool? Status { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual UserRol UserRol { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderApplicants { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderBuyers { get; set; }
    }
}
