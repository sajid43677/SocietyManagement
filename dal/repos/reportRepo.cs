using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class reportRepo : repo, IRepo<report, int, report>
    {
        public report Create(report obj)
        {
            db.reports.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }
        public bool Delete(int id)
    {
        var ex = Read(id);
        db.reports.Remove(ex);
        if (db.SaveChanges() > 0) return true;
        else { return false; }
    }

    public report Read(int id)
    {
        return db.reports.Find(id);
    }

    public List<report> Read()
    {
        return db.reports.ToList();
    }

    public report Update(report obj)
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
