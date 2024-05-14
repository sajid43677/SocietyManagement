using dal.interfaces;
using dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class verificationRepo : repo, IRepo<verification, int, verification>
    {
        public verification Create(verification obj)
    {
        db.verifications.Add(obj);
        if (db.SaveChanges() > 0) return obj;
        else return null;

    }

    public bool Delete(int id)
    {
        var ex = Read(id);
        db.verifications.Remove(ex);
        if (db.SaveChanges() > 0) return true;
        else { return false; }
    }

    public List<verification> Read()
    {
        return db.verifications.ToList();
    }

    public verification Read(int id)
    {
        return db.verifications.Find(id);
    }

    public verification Update(verification obj)
    {
        var ex = db.verifications.Find(obj.vid);
        db.Entry(ex).CurrentValues.SetValues(obj);
        if (db.SaveChanges() > 0) return obj;
        else return null;

    }
}
    
}
