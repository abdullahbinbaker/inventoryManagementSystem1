using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
   public class SalesBill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BillNo { get; set; }
        [Required]
        public string BillType { get; set; }
        public double SalesBillTotalBeforeDiscount { get; set; }
        public string CustomerName { get; set; }
        public int? CustomerId { get; set; }
        [Required]
        public string SalesmanName { get; set; }
        public double SalesBillTotalPriceAfterDiscount { get; set; }
        public double? Discount { get; set; }
        public double BillProfitBeforeDiscount { get; set; }
        public double BillProfitAfterDiscount { get; set; }


    }
}
