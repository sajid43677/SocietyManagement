using dal.interfaces;
using dal.models;
using dal.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class secDataAccessFactory
    {
        public static IRepo<security, int, security> SecurityData()
        {
            return new securityRepo();
        }

        public static IRepo<gatepass, int, gatepass> GatePassData()
        {
            return new gatepassRepo();
        }

        public static IRepo<verification, int, verification> VerificationData()
        {
            return new verificationRepo();
        }
    }
}
