using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
    public class ConTableItemAndBill
    {
        [Key]
        public int BillNo { get; set; }

        [ForeignKey("ItemNo")]
        public string ItemNo { get; set; }
        public int ItemQuantityInTheBill { get; set; }
        public double ItemPriceInTheBill { get; set; }
        public double ItemTotalPriceInTheBill { get; set; }
        public double ItemProfitInTheBill { get; set; }
        public Item Item { get; set; }

    }
}
