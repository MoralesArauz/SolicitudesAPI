using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class PurchaseOrderCategory
    {
        public PurchaseOrderCategory()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int PurchaseOrderCategoryId { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
