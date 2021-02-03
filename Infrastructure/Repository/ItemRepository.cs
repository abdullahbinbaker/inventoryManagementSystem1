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

        public async Task<Item> GetItem(string itemNo)
        {
            return await _context.Set<Item>().Where(x=>x.ItemNo==itemNo).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Item>> GetBadeels(string itemNo)
        {
            return await _context.Set<Item>().Where(item => item.OriginalItemNo == itemNo).ToListAsync();
        }

        public async Task<Item> AddNewItem(Item item)
        {
            var newItem = await _context.Set<Item>().AddAsync(item);
            await _context.SaveChangesAsync();
            return newItem.Entity;
        }

        
        public void UpdateItem(Item item)
        {
            _context.Set<Item>().Update(item);

        }
          //  Item itemToUpdate = _context.Set<Item>().Where(x => x.ItemNo == item.ItemNo).FirstOrDefault();
        //    if (itemToUpdate != null)
        //    {
        //        itemToUpdate.ItemNo = holiday.EmployeeId;
        //        itemToUpdate.NameArabic = holiday.HolidayStartDate;
        //        itemToUpdate.HolidayEndDate = holiday.HolidayEndDate;
        //        itemToUpdate.HolidayStatus = holiday.HolidayStatus;
        //        itemToUpdate.HolidayReason = holiday.HolidayReason;

        //        await _context.SaveChangesAsync();
        //        return toUpdate;
        //    }
        //}

    }
}
