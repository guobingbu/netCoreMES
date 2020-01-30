using bgb.netcore.mes.Domain.Entities;
using bgb.netcore.mes.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bgb.netcore.mes.EntityFrameworkCore.Repositories
{
    public class MenuRepository : bgbmesRepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(bgbmesDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
