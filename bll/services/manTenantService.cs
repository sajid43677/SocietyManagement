﻿using AutoMapper;
using bll.DTOs;
using dal;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.services
{
    public class manTenantService
    {
        public static List<manTenantDTO> Get()
        {
            var data = manDataAccessFactory.tenantData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<tenant, manTenantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<manTenantDTO>>(data);
            return mapped;
        }

        public static manTenantDTO Get(int id)
        {
            var data = manDataAccessFactory.tenantData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<tenant, manTenantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<manTenantDTO>(data);
            return mapped;
        }

        public static manTenantDTO AddTenant(manTenantDTO Tenant)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manTenantDTO, tenant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<tenant>(Tenant);
            var data = manDataAccessFactory.tenantData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<tenant, manTenantDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manTenantDTO>(data);
            return mapped2;
        }

        public static manTenantDTO UpdateTenant(manTenantDTO Tenant)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manTenantDTO, tenant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<tenant>(Tenant);
            var data = manDataAccessFactory.tenantData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<tenant, manTenantDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manTenantDTO>(data);
            return mapped2;
        }

        public static bool DeleteTenant(int id)
        {
            return manDataAccessFactory.tenantData().Delete(id);
        }

        public static manTenantsServices TenantsServices(int userId)
        {
            var utilities = manDataAccessFactory.tenantData().GetTenants(userId);

            var servicesTaken = new List<manServiceStatus>();
            foreach (var item in utilities)
            {
                var service = manDataAccessFactory.serviceData().Read(item.utilityId);
                var serviceStatus = new manServiceStatus()
                {
                    service = service.utilityName,
                    status = item.utilityStatus
                };
                servicesTaken.Add(serviceStatus);
            }
            var data = new manTenantsServices()
            {
                tenantId = userId,
                services = servicesTaken
            };
            return data;   
        }
    }
}
