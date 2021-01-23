using Core.Interfaces;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
//using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DataContext _context;
        public ConTableCustomerAndBillRepository ConTableCustomerAndBill;
        public ConTableItemAndBillRepository ConTableItemAndBill;
        public ConTableItemAndPurchaseBillRepository ConTableItemAndPurchaseBill;
        public CustomerRepository Customer;
        public ItemCostHistoryRepository ItemCostHistory;
        public ItemRepository Item;
        public PurchaseBillRepository PurchaseBill;
        public SalesBillRepository SalesBill;
        public SupplierRepository Supplier;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            ConTableCustomerAndBill = new ConTableCustomerAndBillRepository(_context);
            ConTableItemAndBill = new ConTableItemAndBillRepository(_context);
            ConTableItemAndPurchaseBill = new ConTableItemAndPurchaseBillRepository(_context);
            Customer = new CustomerRepository(_context);
            ItemCostHistory = new ItemCostHistoryRepository(_context);
            Item = new ItemRepository(_context);
            PurchaseBill = new PurchaseBillRepository(_context);
            SalesBill = new SalesBillRepository(_context);
            Supplier = new SupplierRepository(_context);
        }

       
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }
    }
}
