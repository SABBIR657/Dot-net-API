using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace tourManagement.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/user")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.GetUser();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/user/add")]
        [HttpPost]
        public HttpResponseMessage Post(UserDTO user)
        {
            var resp = UserService.Add(user);
            if (resp != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", data = resp });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
