using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminRepo : IRepository<Host, int, bool>
    {
        TMSAPIEntities1 db;
        public AdminRepo(TMSAPIEntities1 db)
        {
            this.db = db;
        }
        public bool Add(Host e)
        {
            // throw new NotImplementedException();
            db.Hosts.Add(e);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.Hosts.Remove(db.Hosts.FirstOrDefault(c => c.hostid == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public bool Edit(Host e)
        {
            var b = db.Hosts.FirstOrDefault(en => en.hostid == e.hostid);
            b.address = e.address;
            b.email = e.email;
            b.mobilenumber = e.mobilenumber;
            b.password = e.password;
            b.username = e.username;
            db.SaveChanges();
            return true;
        }

        public List<Host> Get()
        {
            return db.Hosts.ToList();
        }

        public Host Get(int id)
        {
            return db.Hosts.Find(id);
        }
    }
}
