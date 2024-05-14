using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class commentsRepo : repo, IRepo<comment, int, comment>
    {
        public comment Create(comment obj)
        {
            db.comments.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.comments.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<comment> Read()
        {
            return db.comments.ToList();
        }

        public comment Read(int id)
        {
            return db.comments.Find(id);
        }

        public comment Update(comment obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
