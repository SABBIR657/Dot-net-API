using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class LoginRepo : IRepo<Login, string, Login>
    {
        TMSAPIEntities1 db;
        internal LoginRepo()
        {
            db = new TMSAPIEntities1();
        }

        public Login Add(Login obj)
        {
            db.Logins.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Login> Get()
        {
            return db.Logins.ToList();
        }

        public Login Get(string id)
        {
            return db.Logins.FirstOrDefault(c => c.loginaccess == id);
        }

        public Login Update(Login obj)
        {
            var ext = db.Users.Find(obj.id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return obj;
        }
    }
}
