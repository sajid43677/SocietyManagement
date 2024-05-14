using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class announcementRepo : repo, IRepo<announcement, int, announcement>
    {
        public announcement Create(announcement obj)
        {
            db.announcements.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            if (ex != null)
            {
                db.announcements.Remove(ex);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public announcement Read(int id)
        {
            return db.announcements.Find(id);
        }

        public List<announcement> Read()
        {
            return db.announcements.ToList();
        }

        public announcement Update(announcement obj)
        {
            var ex = Read(obj.Id);
            if (ex != null)
            {
                db.Entry(ex).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0)
                    return obj;
            }
            return null;
        }

    }
}
