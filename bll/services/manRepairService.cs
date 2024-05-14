using AutoMapper;
using bll.DTOs;
using dal;
using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.services
{
    public class manRepairService
    {
        public static List<manRepairDTO> Get()
        {
            var data = manDataAccessFactory.repairData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<repair, manRepairDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<manRepairDTO>>(data);
            return mapped;
        }

        public static manRepairDTO Get(int id)
        {
            var data = manDataAccessFactory.repairData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<repair, manRepairDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<manRepairDTO>(data);
            return mapped;
        }

        public static manRepairDTO Addrepair(manRepairDTO repair)
        {
            var d = manDataAccessFactory.repairData();
            var countOfRepair = d.GetRepairCountForUser(repair.userId);
            if(countOfRepair > 3)
            {
                throw new InvalidOperationException("User has already reached the maximum limit of repairs.");
            }
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manRepairDTO, repair>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<repair>(repair);
            var data = manDataAccessFactory.repairData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<repair, manRepairDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manRepairDTO>(data);
            return mapped2;
        }

        public static manRepairDTO Updaterepair(manRepairDTO repair)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manRepairDTO, repair>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<repair>(repair);
            var data = manDataAccessFactory.repairData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<repair, manRepairDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manRepairDTO>(data);
            return mapped2;
        }

        public static bool Deleterepair(int id)
        {
            return manDataAccessFactory.repairData().Delete(id);
        }

        


    }
}
