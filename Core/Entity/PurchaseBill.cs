using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
    public class PurchaseBill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BillNo { get; set; }
        //public int SupplierId { get; set; }
        public DateTime dateTime { get; set; }
        [Required]
        public string BillType { get; set; }
        [Required]
        public string SupplierName { get; set; }
        public string OriginalPurchaseBillNumber { get; set; }
        public double BillTotalPriceBeforeDiscount { get; set; }
        public double BillTotalPriceAfterDiscount { get; set; }
        public double? Discount { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
    }
}
