using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class userRepo : repo, IRepo<user, int, user>
    {
        public user Create(user obj)
        {
            db.users.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(int id)
        {

            var ex = Read(id);
            db.users.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<user> Read()
        {
            return db.users.ToList();
        }

        public user Read(int id)
        {
            return db.users.Find(id);
        }

        public user Update(user obj)
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
