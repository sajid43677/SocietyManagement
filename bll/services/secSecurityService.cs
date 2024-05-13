using AutoMapper;
using bll.DTOs;
using System;
using dal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal.models;

namespace bll.services
{
    public class secSecurityService
    {
        public static List<secSecurityDTO> Get()
        {
            var data = secDataAccessFactory.SecurityData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<security, secSecurityDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<secSecurityDTO>>(data);
            return mapped;
        }

        public static secSecurityDTO Get(int id)
        {
            var data = secDataAccessFactory.SecurityData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<security, secSecurityDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<secSecurityDTO>(data);
            return mapped;
        }

        public static secSecurityDTO AddSecurity(secSecurityDTO security)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<secSecurityDTO, security>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<security>(security);
            var data = secDataAccessFactory.SecurityData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<security, secSecurityDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<secSecurityDTO>(data);
            return mapped2;
        }


        public static secSecurityDTO Update(secSecurityDTO security)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<secSecurityDTO, security>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<security>(security);
            var data = secDataAccessFactory.SecurityData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<security, secSecurityDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<secSecurityDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return secDataAccessFactory.SecurityData().Delete(id);
        }
    }
}
