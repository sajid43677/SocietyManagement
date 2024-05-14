using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class securityRepo : repo, IRepo<security, int, security>
    {
        public security Create(security obj)
        {
            db.securitys.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.securitys.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<security> Read()
        {
            return db.securitys.ToList();
        }

        public security Read(int id)
        {
            return db.securitys.Find(id);
        }

        public security Update(security obj)
        {
            var ex = db.securitys.Find(obj.sid);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }
    }
}
