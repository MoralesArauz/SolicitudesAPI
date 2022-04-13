using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }

        public string ProductId { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public float UnitPrice { get; set; }
        public int ProductCategoryId { get; set; }
        public bool? Status { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
