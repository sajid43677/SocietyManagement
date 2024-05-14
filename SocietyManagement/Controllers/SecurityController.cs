using bll.DTOs;
using bll.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocietyManagement.Controllers
{
    public class SecurityController : ApiController
    {
        [HttpGet]
        [Route("api/allsecurity")]

        public HttpResponseMessage Securitys()
        {
            try
            {
                var data = secSecurityService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/security/{id}")]

        public HttpResponseMessage SecuritywithId(int id)
        {
            try
            {
                var data = secSecurityService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/security/add")]

        public HttpResponseMessage Create(secSecurityDTO security)
        {
            try
            {
                var data = secSecurityService.AddSecurity(security);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/security/update")]

        public HttpResponseMessage UpdateSecurity(secSecurityDTO security)
        {
            try
            {
                var data = secSecurityService.Update(security);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/security/delete/{id}")]
        public HttpResponseMessage DeleteSecurity(int id)
        {
            try
            {
                var data = secSecurityService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
