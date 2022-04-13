using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class Costumer
    {
        public Costumer()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int CostumerId { get; set; }
        public string IdentificationCard { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
