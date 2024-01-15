using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employee { get; }
        IUserRepository User { get; }
        int SaveChanges();
    }
}
