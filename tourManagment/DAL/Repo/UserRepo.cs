using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<User, int, User>
    {
        TMSAPIEntities1 db;
        internal UserRepo()
        {
            db = new TMSAPIEntities1();
        }
        public User Add(User obj)
        {
            db.Users.Add(obj);

           
           
                db.SaveChanges();
                return obj;
           
           
        }

        public bool Delete(int id)
        {
            db.Users.Remove(db.Users.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var ext = db.Users.Find(obj.userid);
            db.Entry(ext).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return obj;


        }
    }
}
