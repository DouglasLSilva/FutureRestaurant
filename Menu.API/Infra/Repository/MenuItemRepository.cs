using Menu.API.Domain;
using Menu.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Menu.API.Infra.Repository
{
    public class MenuItemRepository : IMenuItemRepository
    {
        MenuContext _context;
        public MenuItemRepository(MenuContext context)
        {
            _context = context;
        }

        public async Task<MenuItem> Add(MenuItem menuItem)
        {
            var entity = await _context.MenuItem.AddAsync(menuItem);
            return entity.Entity;
        }

        public void Delete(MenuItem menuItem)
        {  
            _context.MenuItem.Remove(menuItem);
        }

        public void DeleteById(Guid id)
        {
            var entity = _context.MenuItem.Find(id);
            _context.MenuItem.Remove(entity);
        }

        public async Task<IEnumerable<MenuItem>> Find(Expression<Func<MenuItem, bool>> expression)
        {
            return await _context.MenuItem.Where(expression).ToListAsync();
        }

        public async Task<List<MenuItem>> FindAll()
        {
           return await _context.MenuItem.ToListAsync();
        }

        public async Task<MenuItem> FindByCode(string code)
        {
           return await _context.MenuItem.Where(x => x.Code == code).FirstOrDefaultAsync();
        }

        public async Task<MenuItem> FindById(Guid id)
        {
            return await _context.MenuItem.FindAsync(id);
        }

        public MenuItem Update(MenuItem menuItem)
        {
            return _context.MenuItem.Update(menuItem).Entity;
        }
    }
}
