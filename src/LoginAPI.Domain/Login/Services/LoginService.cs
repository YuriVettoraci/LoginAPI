using LoginAPI.DataTransfer.Login.Request;
using LoginAPI.Domain.Exceptions;
using LoginAPI.Domain.Login.Entities;
using LoginAPI.Domain.Login.Repositories;
using LoginAPI.Domain.Login.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Login.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public LoginEntity Instantiate(LoginRequest request)
        {
            return new LoginEntity(request.Login, request.Password);
        }
    }
}
