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




        // Verification API starts here


        [HttpGet]
        [Route("api/allverificationsdetails")]

        public HttpResponseMessage Verifications()
        {
            try
            {
                var data = secVerificationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/verification/{id}")]

        public HttpResponseMessage VerificationwithId(int id)
        {
            try
            {
                var data = secVerificationService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/verification/add")]

        public HttpResponseMessage AddVerification(secVerificationDTO verification)
        {
            try
            {
                var data = secVerificationService.AddVerification(verification);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/verification/update")]

        public HttpResponseMessage UpdateVerification(secVerificationDTO verification)
        {
            try
            {
                var data = secVerificationService.Update(verification);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/verification/delete/{id}")]
        public HttpResponseMessage DeleteVerification(int id)
        {
            try
            {
                var data = secVerificationService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        //  GatePass API starts here



        [HttpGet]
        [Route("api/allgatepassdetails")]

        public HttpResponseMessage Gatepass()
        {
            try
            {
                var data = secGatepassService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/gatepass/{id}")]

        public HttpResponseMessage GatepasswithId(int id)
        {
            try
            {
                var data = secGatepassService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/gatepass/add")]

        public HttpResponseMessage AddGatePass(secGatePassDTO gatepass)
        {
            try
            {
                var data = secGatepassService.AddGatePass(gatepass);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/gatepass/update")]

        public HttpResponseMessage UpdateGatePass(secGatePassDTO gatepass)
        {
            try
            {
                var data = secGatepassService.UpdateGatePass(gatepass);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/gatepass/delete/{id}")]
        public HttpResponseMessage DeleteGatePass(int id)
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
