using LoginAPI.Domain.Generics;
using LoginAPI.Domain.Login.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Login.Repositories
{
    public interface ILoginRepository : IGenericRepository<LoginEntity>
    {
        
    }
}
