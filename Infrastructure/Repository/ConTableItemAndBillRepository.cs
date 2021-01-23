using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class ConTableItemAndBillRepository
    {
        protected readonly DbContext _context;
        public ConTableItemAndBillRepository(DbContext context)
        {
            _context = context;
        }
    }
}
