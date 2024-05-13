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
    public class manFlatService
    {
        public static List<manFlatDTO> Get()
        {
            var data = manDataAccessFactory.flatData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<flat, manFlatDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<manFlatDTO>>(data);
            return mapped;
        }

        public static manFlatDTO Get(int id)
        {
            var data = manDataAccessFactory.flatData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<flat, manFlatDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<manFlatDTO>(data);
            return mapped;
        }

        public static manFlatDTO AddFlat(manFlatDTO flat)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manFlatDTO, flat>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<flat>(flat);
            var data = manDataAccessFactory.flatData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<flat, manFlatDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manFlatDTO>(data);
            return mapped2;
        }

        public static manFlatDTO UpdateFlat(manFlatDTO flat)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manFlatDTO, flat>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<flat>(flat);
            var data = manDataAccessFactory.flatData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<flat, manFlatDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manFlatDTO>(data);
            return mapped2;
        }

        public static void DeleteFlat(int id)
        {
            manDataAccessFactory.flatData().Delete(id);
        }
    }
}