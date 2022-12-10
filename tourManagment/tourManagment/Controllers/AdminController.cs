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
    public class AdminController : ApiController
    {
        [Route("api/admin/All")]
        [HttpGet]
        public List<AdminModel> getAlladmin()
        {
            return AdminServices.Get();
        }

        [Route("api/admin/Create")]
        [HttpPost]
        public void Createadmin(AdminModel u)
        {
            AdminServices.Create(u);
        }

        [Route("api/admin/Update")]
        [HttpPost]
        public HttpResponseMessage UpdateAdmin(AdminModel user)
        {
            AdminServices.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }

        [Route("api/Admin/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            AdminServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
