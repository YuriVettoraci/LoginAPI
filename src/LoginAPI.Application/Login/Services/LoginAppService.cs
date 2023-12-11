using AutoMapper;
using LoginAPI.Application.Login.Services.Interface;
using LoginAPI.Application.Transactions.Interfaces;
using LoginAPI.DataTransfer.Login.Request;
using LoginAPI.DataTransfer.Login.Response;
using LoginAPI.Domain.Login.Entities;
using LoginAPI.Domain.Login.Repositories;
using LoginAPI.Domain.Login.Services;
using LoginAPI.Domain.Login.Services.Interfaces;
using LoginAPI.Domain.Util;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Application.Login.Services
{
    public class LoginAppService : ILoginAppService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly ILoginService loginService;
        private readonly ILoginRepository loginRepository;
        public LoginAppService(IUnitOfWork unitOfWork, IMapper mapper, ILoginService loginService, ILoginRepository loginRepository)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.loginService = loginService;
            this.loginRepository = loginRepository;
        }

        public LoginResponse GetLogin(int id)
        {
            try
            {
                unitOfWork.BeginTransaction();

                var login = loginRepository.Retrieve(id);

                unitOfWork.Commit();

                return mapper.Map<LoginResponse>(login);
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
                throw new Exception("There was an error while trying to retrieve a login", ex);
            }
        }

        public LoginResponse Insert(LoginRequest request)
        {
            try
            {
                unitOfWork.BeginTransaction();

                LoginEntity login = loginService.Instantiate(request);
                
                var response = loginRepository.Insert(login);

                unitOfWork.Commit();

                return mapper.Map<LoginResponse>(response);
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
                throw new Exception("There was an error while trying to insert a new Login", ex);
            }
        }

        public LoginResponse Update(int id, LoginRequest request)
        {
            try
            {
                unitOfWork.BeginTransaction();

                LoginEntity login = loginRepository.Retrieve(id);

                login.SetLogin(request.Login);
                login.SetPassword(request.Password);

                loginRepository.Update(login);

                unitOfWork.Commit();

                return mapper.Map<LoginResponse>(login);
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
                throw new Exception("There was an error while trying to update this Login data", ex);
            }
        }
    }
}
