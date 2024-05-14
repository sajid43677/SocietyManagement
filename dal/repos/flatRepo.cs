using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class flatRepo : repo, IRepo<flat, int, flat>
    {
        public flat Create(flat obj)
        {
            db.flats.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.flats.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<flat> Read()
        {
            return db.flats.ToList();
        }

        public flat Read(int id)
        {
            return db.flats.Find(id);
        }

        public flat Update(flat obj)
        {
            var ex = db.flats.Find(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;

        }
    }
}
