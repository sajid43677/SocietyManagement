using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class ruleRepo : repo, IRepo<rule, int, rule>
    {
        public rule Create(rule obj)
        {
            db.rules.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.rules.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<rule> Read()
        {
            return db.rules.ToList();
        }

        public rule Read(int id)
        {
            return db.rules.Find(id);
        }

        public rule Update(rule obj)
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
