using LoginAPI.Application.Login.Services.Interface;
using LoginAPI.DataTransfer.Login.Request;
using LoginAPI.DataTransfer.Login.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.API.Controllers.Login
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginAppService loginAppService;

        public LoginController(ILoginAppService loginAppService)
        {
            this.loginAppService = loginAppService;
        }

        ///<summary>
        /// Get login data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<LoginResponse> Retrieve(int id)
        {
            var response = loginAppService.GetLogin(id);

            return Ok(response);
        }

        ///<summary>
        /// Insert new login data.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<LoginResponse> Insert(LoginRequest request)
        {
            var response = loginAppService.Insert(request);

            return Ok(response);
        }

        ///<summary>
        /// Update login data.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<LoginResponse> Update(int id, LoginRequest request)
        {
            var response = loginAppService.Update(id, request);

            return Ok(response);
        }
    }
}
