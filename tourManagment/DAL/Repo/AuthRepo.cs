using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AuthRepo : IAuth
    {
        TMSAPIEntities1 db;

        public AuthRepo(TMSAPIEntities1 db)
        {
            this.db = db;
        }

        public Token Authenticate(string username, string password)
        {
           var u = db.Clients.FirstOrDefault(e => e.username== username && e.password == password);
            if(u != null)
            {
                var g = Guid.NewGuid();
                var token = g.ToString();
                var t = new Token()
                {
                    clientid = u.clientid,
                    tokenaccess = token,
                    Createdat = DateTime.Now,
                    Expireat = DateTime.Now.AddMinutes(10)
                };
                db.Tokens.Add(t);
                db.SaveChanges();
                return t;
            }
            else
            {
                return null;
            }
        }

        public bool IsAuthenticate(string token)
        {
            var ac_token = db.Tokens.FirstOrDefault(e => e.tokenaccess.Equals(token) && e.Expireat == null);
            if(ac_token != null)
            {
                return true;
            }
            return false;
        }

        public bool Logout(int id)
        {
           // throw new NotImplementedException();

            var data = db.Tokens.FirstOrDefault(e => e.clientid== id);
            if(data != null)
            {
                db.Tokens.Remove(data);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
