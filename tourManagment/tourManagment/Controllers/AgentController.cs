using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace tourManagment.Controllers
{
    public class AgentController : ApiController
    {
        [Route("api/agent/All")]
        [HttpGet]
        public List<AgentModel> getAllagent()
        {
            return AgentServices.Get();
        }

        [Route("api/agent/Create")]
        [HttpPost]
        public void Createagent(AgentModel u)
        {
            AgentServices.Create(u);
        }

        [Route("api/agent/Update")]
        [HttpPost]
        public HttpResponseMessage UpdateAgent(AgentModel user)
        {
            AgentServices.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }

        [Route("api/Agent/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            AgentServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }


    }
}
