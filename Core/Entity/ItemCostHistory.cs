using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
   public class ItemCostHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string ItemNo { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string BillNo { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public Boolean IsSold { get; set; }

    }
}
