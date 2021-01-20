using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
   public class ConTableItemAndPurchaseBill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string ItemNo { get; set; }
        public DateTime dateTime { get; set; }
        public int ItemQuantityInTheBill { get; set; }
        public double ItemPriceInTheBill { get; set; }
        public double ItemTotalPriceInTheBill { get; set; }
        public int BillNo { get; set; }
        [ForeignKey("BillNo")]
        public PurchaseBill purchaseBill { get; set; }

    }
}
