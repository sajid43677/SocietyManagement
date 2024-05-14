using bll.DTOs;
using bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocietyManagement.Controllers
{
    public class reportController : ApiController
    {
        [HttpGet]
        [Route("api/reports")]

        public HttpResponseMessage Reports()
        {
            try
            {
                var data = reportServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/report/{id}")]

        public HttpResponseMessage ReportWithId(int id)
        {
            try
            {
                var data = reportServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/report/add")]

        public HttpResponseMessage Create(reportDto report)
        {
            try
            {
                var data = reportServices.Create(report);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/report/update")]

        public HttpResponseMessage UpdateReport(reportDto report)
        {
            try
            {
                var data = reportServices.Update(report);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/report/delete/{id}")]
        public HttpResponseMessage DeleteReport(int id)
        {
            try
            {
                var data = reportServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
