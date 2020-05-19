using Menu.API.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu.API.Infra.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public MenuContext _context;
        private MenuItemRepository _itemRepository;
        public UnitOfWork(MenuContext context)
        {
            _context = context;
        }

        public MenuItemRepository MenuRepository
        {
            get
            {
                return _itemRepository = _itemRepository ?? new MenuItemRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
