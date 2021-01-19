using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entity
{
   public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SupllierId { get; set; }
        public string SupplierName { get; set; }
        public string SsupplierPhoneNumber { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierEmail { get; set; }
        public double? SupplierTotalPurchases { get; set; }

    }
}
