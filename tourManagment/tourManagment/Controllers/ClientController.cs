using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tourManagment.Auth;

namespace tourManagment.Controllers
{
    public class ClientController : ApiController
    {
       
        [Route("api/client/home")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var d = ClientServices.Get();
            if(d != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, d);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
            }
        }
        [Route("api/client/home/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var d = ClientServices.Get(id);
            if(d != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, d);

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
            }
        }

        [Route("api/client/update")]
        [HttpGet]
        public HttpResponseMessage EditProfile(ClientModel user)
        {
            if(ClientServices.Edit(user))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Succefully edited");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Failed to edit profile");
        }
       
        [Route("api/client/All")]
        [HttpGet]
        public List<ClientModel> getAllclient()
        {
            return ClientServices.Getclient();
        }
        
        [Route("api/client/Create")]
        [HttpPost]
        public void Createclient(ClientModel user)
        {
            ClientServices.Create(user);
        }
       
        [Route("api/client/Update")]
        [HttpPost]
        public HttpResponseMessage UpdateClient(ClientModel user)
        {
            ClientServices.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }
        
        [Route("api/client/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Deleteclient(int id)
        {
            ClientServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted Client");
        }
        /*
        [Route("api/client/add")]
        [HttpGet]
        public HttpResponseMessage AddUser(ClientModel c)
        {
            if(ClientServices.Create(c))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Added");

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Try again");
            }
        }
        */
        [Route("api/client/getpackage/{id}")]
        [HttpGet]
        public HttpResponseMessage GetPackage(int id)
        {
            var d = ClientServices.GetPackage(id);
            if(d != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, d);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
            }
        }

        [Route("api/client/deleteuser/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteUsers(int id)
        {
            var data = ClientServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        
        [Route("api/client/addpackage")]
        [HttpPost]
        public HttpResponseMessage AddPackage(BookingModel b)
        {
            if(ClientServices.AddPackage(b))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "package Added");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "not added try again!!");
            }
        }
        
       


        [Route("api/client/deletepackage/{id}")]
        [HttpDelete]

        public HttpResponseMessage DeletePackage(int id)
        {
            var data = ClientServices.DeletePackage(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
