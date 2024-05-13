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
    public class secGatepassService
    {
        public static List<secGatePassDTO> Get()
        {
            var data = secDataAccessFactory.GatePassData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<gatepass, secGatePassDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<secGatePassDTO>>(data);
            return mapped;
        }

        public static secGatePassDTO Get(int id)
        {
            var data = secDataAccessFactory.GatePassData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<gatepass, secGatePassDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<secGatePassDTO>(data);
            return mapped;
        }

        public static secGatePassDTO AddGatePass(secGatePassDTO gatepass)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<secGatePassDTO, gatepass>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<gatepass>(gatepass);
            var data = secDataAccessFactory.GatePassData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<gatepass, secGatePassDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<secGatePassDTO>(data);
            return mapped2;
        }


        public static secGatePassDTO UpdateGatePass(secGatePassDTO gatepass)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<secGatePassDTO, gatepass>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<gatepass>(gatepass);
            var data = secDataAccessFactory.GatePassData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<gatepass, secGatePassDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<secGatePassDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return secDataAccessFactory.GatePassData().Delete(id);
        }
    }
}
