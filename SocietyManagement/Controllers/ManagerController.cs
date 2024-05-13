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
    public class ManagerController : ApiController
    {
        #region Flat
        [HttpGet]
        [Route("api/allflat")]

        public HttpResponseMessage Flats()
        {
            try
            {
                var data = manFlatService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/flat/{id}")]
        public HttpResponseMessage FlatwithId(int id)
        {
            try
            {
                var data = manFlatService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/flat/add")]
        public HttpResponseMessage Create(manFlatDTO flat)
        {
            try
            {
                var data = manFlatService.AddFlat(flat);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/flat/update")]
        public HttpResponseMessage Update(manFlatDTO flat)
        {
            try
            {
                var data = manFlatService.UpdateFlat(flat);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/flat/delete/{id}")]
        public HttpResponseMessage DeleteFlat(int id)
        {
            try
            {
                var data = manFlatService.DeleteFlat(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        #endregion

        #region Service

        [HttpGet]
        [Route("api/allservice")]
        
        public HttpResponseMessage Services()
        {
            try
            {
                var data = manServiceService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/service/{id}")]
        public HttpResponseMessage ServicewithId(int id)
        {
            try
            {
                var data = manServiceService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/service/add")]
        public HttpResponseMessage Create(manServiceDTO service)
        {
            try
            {
                var data = manServiceService.AddService(service);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/service/update")]
        public HttpResponseMessage Update(manServiceDTO service)
        {
            try
            {
                var data = manServiceService.UpdateService(service);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/service/delete/{id}")]
        public HttpResponseMessage DeleteService(int id)
        {
            try
            {
                var data = manServiceService.DeleteService(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        #endregion

        #region Repair

        [HttpGet]
        [Route("api/allrepair")]

        public HttpResponseMessage Repairs()
        {
            try
            {
                var data = manRepairService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/repair/{id}")]
        public HttpResponseMessage RepairwithId(int id)
        {
            try
            {
                var data = manRepairService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/repair/add")]
        public HttpResponseMessage Create(manRepairDTO repair)
        {
            try
            {
                var data = manRepairService.Addrepair(repair);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/repair/update")]
        public HttpResponseMessage Update(manRepairDTO repair)
        {
            try
            {
                var data = manRepairService.Updaterepair(repair);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/repair/delete/{id}")]
        public HttpResponseMessage DeleteRepair(int id)
        {
            try
            {
                var data = manRepairService.Deleterepair(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        #endregion

        #region Tenant
        [HttpGet]
        [Route("api/alltenant")]
        public HttpResponseMessage tenants()
        {
            try
            {
                var data = manTenantService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/tenant/{id}")]
        public HttpResponseMessage TenantwithId(int id)
        {
            try
            {
                var data = manTenantService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/tenant/add")]
        public HttpResponseMessage Create(manTenantDTO tenant)
        {
            try
            {
                var data = manTenantService.AddTenant(tenant);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/tenant/update")]
        public HttpResponseMessage Update(manTenantDTO tenant)
        {
            try
            {
                var data = manTenantService.UpdateTenant(tenant);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/tenant/delete/{id}")]
        public HttpResponseMessage DeleteTenant(int id)
        {
            try
            {
                var data = manTenantService.DeleteTenant(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        #endregion
    }
}
