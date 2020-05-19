using Menu.API.Domain;
using Menu.API.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Menu.API.BusinessLogic
{
    public class MenuItemBusinessLogic : IDisposable
    {
        UnitOfWork _unit;

        public MenuItemBusinessLogic(UnitOfWork unit)
        {
            _unit = unit;
        }

        public async Task<MenuItem> Add(MenuItem menuItem)
        {
            var entity = await _unit.MenuRepository.Add(menuItem);
            _unit.Commit();
            return entity;
        }

        public void Delete(MenuItem menuItem)
        {
            _unit.MenuRepository.Delete(menuItem);
            _unit.Commit();
        }

        public void DeleteById(Guid id)
        {
            _unit.MenuRepository.DeleteById(id);
            _unit.Commit();
        }

        public async Task<IEnumerable<MenuItem>> Find(Expression<Func<MenuItem, bool>> expression)
        {
            return await _unit.MenuRepository.Find(expression);
        }

        public async Task<List<MenuItem>> FindAll()
        {
            return await _unit.MenuRepository.FindAll();
        }

        public async Task<MenuItem> FindByCode(string code)
        {
            return await _unit.MenuRepository.FindByCode(code);
        }

        public async Task<MenuItem> FindById(Guid id)
        {
            return await _unit.MenuRepository.FindById(id);
        }

        public MenuItem Update(MenuItem menuItem)
        {
            var entity = _unit.MenuRepository.Update(menuItem);
            _unit.Commit();
            return entity;
        }

        public void Dispose()
        {
            _unit.Dispose();
        }
    }
}
