using AutoMapper;
using bll.DTOs;
using dal;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.Services
{
    public class ruleServices
    {
        public static List<ruleDto> Get()
        {
            var data = DataAccessFactory.RuleData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<rule, ruleDto>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ruleDto>>(data);
            return mapped;
        }

        public static ruleDto Get(int id)
        {
            var data = DataAccessFactory.RuleData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<rule, ruleDto>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ruleDto>(data);
            return mapped;
        }

        public static ruleDto AddRule(ruleDto rule)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ruleDto,rule>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<rule>(rule);
            var data = DataAccessFactory.RuleData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<rule, ruleDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<ruleDto>(data);
            return mapped2;

        }

        public static ruleDto Update(ruleDto rule)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ruleDto, rule>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<rule>(rule);
            var data = DataAccessFactory.RuleData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<rule, ruleDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<ruleDto>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.RuleData().Delete(id);
        }
    }
}
