using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
    public class ConTableCustomerAndBill
    {
        [Key]
        public int CustomerId { get; set; }
        public int BillNo { get; set; }
        public double TotalBillBeforeDiscount { get; set; }
        public double TotalBillAfterDiscount { get; set; }
        [ForeignKey("SupplierId")]
        public Customer Customer { get; set; }
        public double? Discount { get; set; }
    }
}
