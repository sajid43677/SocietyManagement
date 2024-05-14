using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class serviceRepo : repo, IRepo<service, int, service>
    {
        public service Create(service obj)
        {
            db.services.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.services.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<service> Read()
        {
            return db.services.ToList();
        }

        public service Read(int id)
        {
            return db.services.Find(id);
        }

        public service Update(service obj)
        {
            var ex = db.services.Find(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }
    }
}
