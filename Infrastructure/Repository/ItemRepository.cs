using Core.Entity;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ItemRepository
    {
        protected readonly DbContext _context;
        public ItemRepository(DbContext context) 
        {
            _context = context;
        }

        public async Task<Item> RetreiveItemInformation(string itemNo)
        {
            return await _context.Set<Item>().Where(x=>x.ItemNo==itemNo).FirstOrDefaultAsync();
        }

        public async Task<List<Item>> LoadBadeel(string itemNo)
        {
            return await _context.Set<Item>().Where(item => item.OriginalItemNo == itemNo).ToListAsync();
 
        }

        public async Task<Item> AddNewItem(Item item)
        {
            var newItem = await _context.Set<Item>().AddAsync(item);
            await _context.SaveChangesAsync();
            return newItem.Entity;
        }

        //public async Task<Item> UpdateItem(Item item)
        //{

        //}

    }
}
