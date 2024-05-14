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
    public class CommentController : ApiController
    {
        [HttpGet]
        [Route("api/comments")]

        public HttpResponseMessage Comments()
        {
            try
            {
                var data = commentServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/comment/{id}")]

        public HttpResponseMessage CommentWithId(int id)
        {
            try
            {
                var data = commentServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/comment/add")]

        public HttpResponseMessage Create(commentDto comment)
        {
            try
            {
                var data = commentServices.Create(comment);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/comment/update")]

        public HttpResponseMessage UpdateComment(commentDto comment)
        {
            try
            {
                var data =commentServices.Update(comment);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/comment/delete/{id}")]
        public HttpResponseMessage DeleteComment(int id)
        {
            try
            {
                var data = commentServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
