using FluentNHibernate.Mapping;
using LoginAPI.Domain.Login.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Infrastructure.Login.Mappings
{
    public class LoginMap : ClassMap<LoginEntity>
    {
        public LoginMap() 
        {
            Schema("cognito");
            Table("login");
            Id(login => login.Id).Column("id");
            Map(login => login.Login).Column("Login");
            Map(login => login.Password).Column("password");
        }
    }
}
