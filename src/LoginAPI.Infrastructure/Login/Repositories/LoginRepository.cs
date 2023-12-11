using LoginAPI.Domain.Login.Entities;
using LoginAPI.Domain.Login.Repositories;
using LoginAPI.Infrastructure.Generics;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Infrastructure.Login.Repositories
{
    public class LoginRepository : GenericRepository<LoginEntity>, ILoginRepository
    {
        public LoginRepository(ISession session) :base(session) { }
    }
}
