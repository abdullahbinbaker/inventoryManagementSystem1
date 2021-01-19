using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entity
{
    public class Item
    {
        [Key]
        public string ItemNo { get; set; }
        public string NameArabic { get; set; }
        public string NameEnglish { get; set; }
        public double? Price1 { get; set; }
        public double? Price2 { get; set; }
        public double? Price3 { get; set; }
        public double? CurrentCost { get; set; }
        public int? CurrentInventory { get; set; }
        public int? StockForTheFirstTerm { get; set; }
        public int? StockForTheLastTerm { get; set; }
        public int? Purchases { get; set; }
        public int? Sales { get; set; }
        public string OriginalItemNo { get; set; }
        public string Location1 { get; set; }
        public string Location2 { get; set; }
        public string Location3 { get; set; }

    }
}
