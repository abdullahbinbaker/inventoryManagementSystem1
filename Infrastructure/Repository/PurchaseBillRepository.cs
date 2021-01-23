using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
   public class PurchaseBillRepository
    {
        protected readonly DbContext _context;
        public PurchaseBillRepository(DbContext context)
        {
            _context = context;
        }
    }
}
