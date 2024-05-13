using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class tenantRepo : repo, IRepo<tenant, int, tenant>
    {
        public tenant Create(tenant obj)
        {
            db.tenants.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.tenants.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<tenant> Read()
        {
            return db.tenants.ToList();
        }

        public tenant Read(int id)
        {
            return db.tenants.Find(id);
        }

        public tenant Update(tenant obj)
        {
            var ex = db.tenants.Find(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }
    }
}
