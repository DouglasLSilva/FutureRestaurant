using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Menu.API.Domain.Interfaces
{
    public interface IMenuItemRepository
    {
        //CREATE
        Task<MenuItem> Add(MenuItem menuItem);

        //READ
        Task<List<MenuItem>> FindAll();
        Task<MenuItem> FindByCode(string code);
        Task<MenuItem> FindById(Guid id);

        Task<IEnumerable<MenuItem>> Find(Expression<Func<MenuItem, bool>> expression);

        //UPDATE
        MenuItem Update(MenuItem menuItem);

        //DELETE
        void Delete(MenuItem menuItem);
        void DeleteById(Guid id);
    }
}
