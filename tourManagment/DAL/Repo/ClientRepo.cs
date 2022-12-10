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
    internal class ClientRepo : IRepository<Client, int, bool>
    {
        /*
        TMSAPIEntities db;

        public ClientRepo(TMSAPIEntities db)
        {
            this.db = db;
        }

        public void Add(Client e)
        {
           this.db.Clients.Add(e);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
           var clnt = db.Clients.FirstOrDefault(c => c.clientid== id);
            db.Clients.Remove(clnt);
            db.SaveChanges();
        }

        public void Edit(Client e)
        {
           var b = db.Clients.FirstOrDefault(en => en.clientid== e.clientid);
            db.Entry(b).CurrentValues.SetValues(e);
            db.SaveChanges() ;
        }

        public List<Client> Get()
        {
           return db.Clients.ToList();
        }

        public Client Get(int id)
        {
           return db.Clients.FirstOrDefault(c => c.clientid== id);
        }
        */
        TMSAPIEntities1 db;
        public ClientRepo(TMSAPIEntities1 db)
        {
            this.db = db;
        }
        public bool Add(Client e)
        {
           
            
            db.Clients.Add(e);
            
           
                var res = db.SaveChanges();
                return res > 0;

            
           
            
           


        }

        public bool Delete(int id)
        {
            db.Clients.Remove(db.Clients.FirstOrDefault(c => c.clientid == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public bool Edit(Client e)
        {
            var b = db.Clients.FirstOrDefault(en => en.clientid == e.clientid);
                b.clientemail = e.clientemail;
            b.clientcontact = e.clientcontact;
            b.clientname = e.clientname;
            b.password = e.password;
            b.username = e.username;
            db.SaveChanges();
            return true;
        }

        public List<Client> Get()
        {
            return db.Clients.ToList();
        }

        public Client Get(int id)
        {
            return db.Clients.Find(id);
        }
    }
}
