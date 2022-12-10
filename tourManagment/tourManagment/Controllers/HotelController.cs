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
    public class HotelController : ApiController
    {

        [Route("api/hotels")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = HotelService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/hotels/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = HotelService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/hotels/add")]
        [HttpPost]
        public HttpResponseMessage Post(HotelModel h)
        {
            var resp = HotelService.Add(h);
            if (resp)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", data = h });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        [Route("api/hotels/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = HotelService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }

        [Route("api/hotels/update")]
        [HttpPost]
        public HttpResponseMessage Update(HotelModel s)
        {
            HotelService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }
    }
}
