using AutoMapper;
using bll.DTOs;
using dal.models;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.services
{
    public class manServiceService
    {
        public static List<manServiceDTO> Get()
        {
            var data = manDataAccessFactory.serviceData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<service, manServiceDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<manServiceDTO>>(data);
            return mapped;
        }

        public static manServiceDTO Get(int id)
        {
            var data = manDataAccessFactory.serviceData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<service, manServiceDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<manServiceDTO>(data);
            return mapped;
        }

        public static manServiceDTO AddService(manServiceDTO Service)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manServiceDTO, service>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<service>(Service);
            var data = manDataAccessFactory.serviceData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<service, manServiceDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manServiceDTO>(data);
            return mapped2;
        }

        public static manServiceDTO UpdateService(manServiceDTO Service)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manServiceDTO, service>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<service>(Service);
            var data = manDataAccessFactory.serviceData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<service, manServiceDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manServiceDTO>(data);
            return mapped2;
        }

        public static bool DeleteService(int id)
        {
            return manDataAccessFactory.serviceData().Delete(id);
        }

        
    }
}
