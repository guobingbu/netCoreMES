using bgb.netcore.mes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bgb.netcore.mes.Domain.IRepositories
{
    public interface IDepartmentRepository : IRepository<Department, Guid>
    {
    }
}
