using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        //IItemCostHistoryRepository CostHistoryRepository { get; }
        //IConTableCustomerAndBillRepository ConTableCustomerAndBillRepository { get; }
        //IConTableItemAndBillRepository ItemAndBillRepository { get; }
        //IConTableItemAndPurchaseBillRepository ItemAndPurchaseBillRepository { get; }
        //ICustomerRepository CustomerRepository { get; }
        //IItemRepository ItemRepository { get; }
        //IPurchaseBillRepository PurchaseBillRepository { get; }
        //ISalesBillRepository SalesBillRepository { get; }
        //ISupplierRepository SupplierRepository { get; }

        Task<bool> SaveAsync();
    }
}