using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.interfaces
{
    public interface ITenantRepo : IRepo<tenant, int, tenant>
    {
        List<tenant> GetTenants(int userId);
    }
}
