using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class SupplierRepository
    {
        protected readonly DbContext _context;
        public SupplierRepository(DbContext context)
        {
            _context = context;
        }
    }
}
