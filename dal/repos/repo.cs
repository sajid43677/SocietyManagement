using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repos
{
    internal class repo
    {
        internal SMContext db;

        internal repo()
        {
            db = new SMContext(); 

        }
    }
}
