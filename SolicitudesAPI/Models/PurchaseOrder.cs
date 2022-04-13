using System;
using System.Collections.Generic;

namespace SolicitudesAPI.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }

        public string PurchaseOrderId { get; set; }
        public int BuyerId { get; set; }
        public int CostumerId { get; set; }
        public int ApplicantId { get; set; }
        public byte[] Image { get; set; }
        public DateTime Date { get; set; }
        public int PurchaseOrderCategoryId { get; set; }
        public bool? Status { get; set; }
        public string Details { get; set; }

        public virtual User Applicant { get; set; }
        public virtual User Buyer { get; set; }
        public virtual Costumer Costumer { get; set; }
        public virtual PurchaseOrderCategory PurchaseOrderCategory { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
