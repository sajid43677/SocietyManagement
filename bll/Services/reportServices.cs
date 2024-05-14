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
    public class reportServices
    {
        public static List<reportDto> Get()
        {
            var data = DataAccessFactory.ReportData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<report, reportDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<reportDto>>(data);
            return mapped;
        }

        public static reportDto Get(int id)
        {
            var data = DataAccessFactory.ReportData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<report, reportDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<reportDto>(data);
            return mapped;

        }

        public static reportDto Create(reportDto report)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<reportDto, report>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<report>(report);

            var data = DataAccessFactory.ReportData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<report, reportDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<reportDto>(data);
            return mapped2;
        }
        public static reportDto Update(reportDto report)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<reportDto, report>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<report>(report);
            var data = DataAccessFactory.ReportData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<report, reportDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<reportDto>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ReportData().Delete(id);
        }
    }
}
