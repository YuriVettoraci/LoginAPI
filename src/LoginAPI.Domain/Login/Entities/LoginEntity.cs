using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Login.Entities
{
    public class LoginEntity
    {
        public virtual int Id { get; protected set; }
        public virtual string Login {  get; protected set; }
        public virtual string Password { get; protected set; }

        public LoginEntity() { }

        public LoginEntity(string login, string password)
        {
            SetLogin(login);
            SetPassword(password);
        }

        public virtual void SetLogin(string login)
        {
            if(login is null)
                throw new Exception("Login can't be null");
            
            if(login.Length < 4)
                throw new Exception("Login must have at least 4 characters");

            Login = login;
        }

        public virtual void SetPassword(string password)
        {
            if(password is null)
                throw new Exception("Password can't be null");

            if (password.Length < 10)
                throw new Exception("Password must have at least 10 characters");

            Password = password;
        }
    }
}
