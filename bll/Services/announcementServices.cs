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
    public class announcementServices
    {
        public static List<announcementDto> Get()
        {
            var data = DataAccessFactory.AnnouncementData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<announcement, announcementDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<announcementDto>>(data);
            return mapped;
        }

        public static announcementDto Get(int id)
        {
            var data = DataAccessFactory.AnnouncementData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<announcement, announcementDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<announcementDto>(data);
            return mapped;

        }

        public static announcementDto GetWithComments(int id)
        {
            var data = DataAccessFactory.AnnouncementData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<announcement, announcementCommentDto>();
                c.CreateMap<comment,commentDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<announcementCommentDto>(data);
            return mapped;
        }

        public static announcementDto Create(announcementDto announcement)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<announcementDto, announcement>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<announcement>(announcement);

            var data = DataAccessFactory.AnnouncementData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<announcement, announcementDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<announcementDto>(data);
            return mapped2;
        }

        public static announcementDto Update(announcementDto announcement)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<announcementDto, announcement>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<announcement>(announcement);
            var data = DataAccessFactory.AnnouncementData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<announcement, announcementDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<announcementDto>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.AnnouncementData().Delete(id);
        }

    }
}
