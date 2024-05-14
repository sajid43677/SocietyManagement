using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class gatepassRepo : repo, IRepo<gatepass, int, gatepass>
    {
        public gatepass Create(gatepass obj)
        {
            db.gatepasses.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.gatepasses.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<gatepass> Read()
        {
            return db.gatepasses.ToList();
        }

        public gatepass Read(int id)
        {
            return db.gatepasses.Find(id);
        }

        public gatepass Update(gatepass obj)
        {
            var ex = db.gatepasses.Find(obj.pid);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }
    }

}
