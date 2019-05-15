using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shalashShop
{
    public class itemInItemReportForm
    {
        public string itemNo { get; set; }
        public string itemNameArabic { get; set; }
        public string itemNameEnglish { get; set; }
        public string price1 { get; set; }
        public string price2 { get; set; }
        public string price3 { get; set; }
        public string currentCost { get; set; }
        public string lastCost { get; set; }
        public string currentInventory { get; set; }
        public string location { get; set; }
        public string sales { get; set; }
        public string purchases { get; set; }

        public itemInItemReportForm(string itemNo, string itemNameArabic, string itemNameEnglish, string price1, string price2, string price3, string currentCost, string lastCost, string currentInventory, string location, string sales, string purchases)
        {
            this.itemNo = itemNo;
            this.itemNameArabic = itemNameArabic;
            this.itemNameEnglish = itemNameEnglish;
            this.price1 = price1;
            this.price2 = price2;
            this.price3 = price3;
            this.currentCost = currentCost;
            this.lastCost = lastCost;
            this.currentInventory = currentInventory;
            this.location = location;
            this.sales = sales;
            this.purchases = purchases;
        }
    }
}
