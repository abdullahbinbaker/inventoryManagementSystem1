using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class CustomerRepository
    {
        protected readonly DbContext _context;
        public CustomerRepository(DbContext context)
        {
            _context = context;
        }
    }
}
