using AutoMapper;
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
    public class secVerificationService
    {
        public static List<secVerificationDTO> Get()
        {
            var data = secDataAccessFactory.VerificationData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<verification, secVerificationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<secVerificationDTO>>(data);
            return mapped;
        }

        public static secVerificationDTO Get(int id)
        {
            var data = secDataAccessFactory.VerificationData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<verification, secVerificationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<secVerificationDTO>(data);
            return mapped;
        }

        public static secVerificationDTO AddVerification(secVerificationDTO verification)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<secVerificationDTO, verification>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<verification>(verification);
            var data = secDataAccessFactory.VerificationData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<verification, secVerificationDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<secVerificationDTO>(data);
            return mapped2;
        }


        public static secVerificationDTO Update(secVerificationDTO verification)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<secVerificationDTO, verification>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<verification>(verification);
            var data = secDataAccessFactory.VerificationData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<verification, secVerificationDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<secVerificationDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return secDataAccessFactory.VerificationData().Delete(id);
        }
    }
}
