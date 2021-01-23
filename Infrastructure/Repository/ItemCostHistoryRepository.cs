using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class ItemCostHistoryRepository
    {
        protected readonly DataContext _context;
        public ItemCostHistoryRepository(DataContext context)
        {
            _context = context;
        }
    }
}
