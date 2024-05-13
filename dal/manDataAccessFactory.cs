﻿using dal.interfaces;
using dal.models;
using dal.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class manDataAccessFactory
    {
        public static IRepo<tenant, int, tenant> TenantData(){
            return new tenantRepo();
        }

        public static IRepo<service, int, service> serviceData()
        {
            return new serviceRepo();
        }

        public static IRepo<repair, int, repair> repairData()
        {
            return new repairRepo();
        }

        public static IRepo<flat, int, flat> flatData()
        {
            return new flatRepo();
        }
    }
}
