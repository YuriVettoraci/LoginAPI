using LoginAPI.DataTransfer.Login.Request;
using LoginAPI.DataTransfer.Login.Response;
using LoginAPI.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Application.Login.Services.Interface
{
    public interface ILoginAppService
    {
        LoginResponse GetLogin(int id);
        LoginResponse Insert(LoginRequest request);
        LoginResponse Update(int id, LoginRequest request);
    }
}
