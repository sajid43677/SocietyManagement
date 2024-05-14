using bll.DTOs;
using bll.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;



namespace SocietyManagement.Controllers
{
    public class AnnouncementController : ApiController
    {
        [HttpGet]
        [Route("api/announcements")]
        public HttpResponseMessage Announcements()
        {
            try
            {
                var data = announcementServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,new{Message= ex.Message });
            }
        }
        [HttpGet]
        [Route("api/announcement/${id}")]
        public HttpResponseMessage Announcement(int id)
        {
           
                var data = announcementServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
           
            
        }
        [HttpGet]
        [Route("api/announcement/${id}/comments")]
        public HttpResponseMessage AnnouncementComments(int id)
        {
            try
            {
                var data = announcementServices.GetWithComments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/announcements")]
        public HttpResponseMessage CreateAnnouncement([FromBody] announcementDto announcementDto)
        {
           
                var createdAnnouncement = announcementServices.Create(announcementDto);
                if (createdAnnouncement != null)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, createdAnnouncement);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Failed to create announcement" });
                }
            
        }

        [HttpPut]
        [Route("api/announcements/update")]

        public HttpResponseMessage UpdateSecurity(announcementDto announcement)
        {
            try
            {
                var data = announcementServices.Update(announcement);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/announcements/delete/{id}")]
        public HttpResponseMessage DeleteSecurity(int id)
        {
            try
            {
                var data = announcementServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
