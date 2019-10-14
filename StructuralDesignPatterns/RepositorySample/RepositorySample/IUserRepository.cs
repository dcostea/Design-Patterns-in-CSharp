using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorySample
{
    interface IUserRepository : IRepository<T>
    {
        T GetByName(string name);
    }
}
