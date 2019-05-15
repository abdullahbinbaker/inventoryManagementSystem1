using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shalashShop
{
   public class itemInSalesBill
    {
      
        public int billNo { get; set; }
        public int itemQuantityInTheBill { get; set; }
        public decimal itemPriceInTheBill { get; set; }
        public decimal itemTotalPriceInTheBill{ get; set; }
        public string itemNo { get; set; }
        public string itemNameInArabic { get; set; }
        public decimal itemProfitInTheBill { get; set; }

        public itemInSalesBill(int billNo, string itemNo, int quantity, decimal itemPriceInTheBill, decimal itemTotalPriceInTheBill ,string itemNameInArabic)
        {
            this.billNo = billNo;
            this.itemNo = itemNo;
            this.itemPriceInTheBill = itemPriceInTheBill;
            itemQuantityInTheBill = quantity;
            this.itemTotalPriceInTheBill = itemTotalPriceInTheBill;
            this.itemNameInArabic = itemNameInArabic;
        }

        public itemInSalesBill(int billNo, string itemNo, int quantity, decimal itemPriceInTheBill, decimal itemTotalPriceInTheBill, string itemNameInArabic, decimal itemProfitInTheBill)
        {
            this.billNo = billNo;
            this.itemNo = itemNo;
            this.itemPriceInTheBill = itemPriceInTheBill;
            itemQuantityInTheBill = quantity;
            this.itemTotalPriceInTheBill = itemTotalPriceInTheBill;
            this.itemNameInArabic = itemNameInArabic;
            this.itemProfitInTheBill = itemProfitInTheBill;
        }
    }
    
}
