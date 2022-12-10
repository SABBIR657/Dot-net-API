using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class packageRepo : IPackageRepo<Package, int>
    {
        TMSAPIEntities1 db;

        public packageRepo(TMSAPIEntities1 db)
        {
            this.db = db;
        }

        public List<Package> Get()
        {
            return db.Packages.ToList();
        }

        public Package Get(int id)
        {
            return db.Packages.FirstOrDefault(c => c.packageid== id);
        }
    }
}
