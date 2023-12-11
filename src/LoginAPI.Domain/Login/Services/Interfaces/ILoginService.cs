using LoginAPI.DataTransfer.Login.Request;
using LoginAPI.Domain.Login.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Login.Services.Interfaces
{
    public interface ILoginService
    {
        LoginEntity Instantiate(LoginRequest request);
    }
}
