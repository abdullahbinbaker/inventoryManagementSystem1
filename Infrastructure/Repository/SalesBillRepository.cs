using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class SalesBillRepository
    {
        protected readonly DbContext _context;
        public SalesBillRepository(DbContext context)
        {
            _context = context;
        }
    }
}
