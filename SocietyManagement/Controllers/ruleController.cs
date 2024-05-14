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
    public class ruleController : ApiController
    {
        [HttpGet]
        [Route("api/rules")]

        public HttpResponseMessage Rules()
        {
            try
            {
                var data = ruleServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/rule/{id}")]

        public HttpResponseMessage RuleWithId(int id)
        {
            try
            {
                var data = ruleServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/rule/add")]

        public HttpResponseMessage Create(ruleDto rule)
        {
            try
            {
                var data = ruleServices.AddRule(rule);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/rule/update")]

        public HttpResponseMessage UpdateRule(ruleDto rule)
        {
            try
            {
                var data = ruleServices.Update(rule);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/rule/delete/{id}")]
        public HttpResponseMessage DeleteRule(int id)
        {
            try
            {
                var data = ruleServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
