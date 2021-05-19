using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.Dtos;
using WEBAPI.Interface;

namespace WEBAPI.Controllers
{
   
    public class AccountController : BaseController
    {
        private readonly IUnitOfWork uow;

        public AccountController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        //api/account/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginReqDto loginReq)
        {
            var user = await uow.UserRepository.Authenticate(loginReq.UserName,loginReq.Password);
            if(user ==null)
            {
                return Unauthorized();
            }

            LoginResDto loginRes = new LoginResDto();
            loginRes.UserName = user.UserName;
            loginRes.Token = "Token to be generated";
            return Ok(loginRes);
        }
    }
}
