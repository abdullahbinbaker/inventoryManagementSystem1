using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class ConTableItemAndPurchaseBillRepository
    {
        protected readonly DbContext _context;
        public ConTableItemAndPurchaseBillRepository(DbContext context)
        {
            _context = context;
        }
    }
}
