using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Client.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/Auth/login")]
        public HttpResponseMessage Login(UserModel u)
        {
            var data = AuthServices.Authenticate(u.username, u.password);
            if (data == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Invalid username or password");
            }
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Auth/logout/{uid}")]
        public HttpResponseMessage Logout(int uid)
        {
            var data = AuthServices.Logout(uid);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully Logged Out");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Already Loggedout");
        }
    }
}
