using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class PurchaseOrderDetail
    {
        public int PurchaseOrderDetailId { get; set; }
        public string PurchaseOrderId { get; set; }
        public string ProductId { get; set; }
        public float Quantity { get; set; }
        public float UnitPrice { get; set; }

        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
