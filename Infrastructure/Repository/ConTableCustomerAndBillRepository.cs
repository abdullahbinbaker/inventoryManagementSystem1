using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class ConTableCustomerAndBillRepository
    {
        protected readonly DbContext _context;
        public ConTableCustomerAndBillRepository(DbContext context)
        {
            _context = context;
        }
    }
}
