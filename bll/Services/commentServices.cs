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
    public class commentServices
    {
        public static List<commentDto> Get()
        {
            var data = DataAccessFactory.CommentData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<comment, commentDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<commentDto>>(data);
            return mapped;
        }

        public static commentDto Get(int id)
        {
            var data = DataAccessFactory.CommentData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<comment, commentDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<commentDto>(data);
            return mapped;

        }

        public static commentDto Create(commentDto comment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<commentDto, comment>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<comment>(comment);

            var data = DataAccessFactory.CommentData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<comment, commentDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<commentDto>(data);
            return mapped2;
        }
        public static commentDto Update(commentDto comment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<commentDto, comment>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<comment>(comment);
            var data = DataAccessFactory.CommentData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<comment, commentDto>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<commentDto>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CommentData().Delete(id);
        }
    }
}
