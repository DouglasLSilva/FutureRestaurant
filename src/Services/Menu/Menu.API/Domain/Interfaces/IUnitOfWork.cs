using Menu.API.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu.API.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        MenuItemRepository MenuRepository { get; }
        void Commit();
    }
}
