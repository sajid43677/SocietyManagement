using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class repairRepo : repo, IRepairRepo
    {
        public repair Create(repair obj)
        {
            db.repairs.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.repairs.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

       

        public List<repair> Read()
        {
            return db.repairs.ToList();
        }

        public repair Read(int id)
        {
            return db.repairs.Find(id);
        }

        public repair Update(repair obj)
        {
            var ex = db.repairs.Find(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }

        public int GetRepairCountForUser(int userId)
        {
            var data = db.repairs.Where(r => r.userId == userId && r.repairStatus.Equals("pending")).ToList();
            return data.Count;
        }
    }
}
