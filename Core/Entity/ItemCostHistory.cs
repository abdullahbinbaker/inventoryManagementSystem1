using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
   public class ItemCostHistory
    {
        [Key]
        public string ItemNo { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? Quantity { get; set; }
        public double? Cost { get; set; }

        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }

    }
}
