using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AgentRepo : IRepository<Agent, int, bool>
    {
        /*
        TMSAPIEntities db;

        public AgentRepo(TMSAPIEntities db)
        {
            this.db = db;
        }
        public bool Add(Agent e)
        {
            db.Agents.Add(e);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
           db.Agents.Remove(db.Agents.FirstOrDefault(c => c.agentid== id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public bool Edit(Agent e)
        {
            var b = db.Agents.FirstOrDefault(en => en.agentid== e.agentid);
            b.agentmail= e.agentmail;
            b.agentcontact= e.agentcontact;
            b.agentname= e.agentname;
            b.password= e.password;
            b.username= e.username;
            db.SaveChanges();
            return true;
        }

        public List<Agent> Get()
        {
           return db.Agents.ToList();
        }

        public Agent Get(int id)
        {
            return db.Agents.Find(id);
        }
        */

        TMSAPIEntities1 db;
        
        public AgentRepo(TMSAPIEntities1 db)
        {
            this.db = db;
        }

        public bool Add(Agent e)
        {
            db.Agents.Add(e);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.Agents.Remove(db.Agents.FirstOrDefault(c => c.agentid == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public bool Edit(Agent e)
        {
            var b = db.Agents.FirstOrDefault(en => en.agentid == e.agentid);
            b.agentmail = e.agentmail;
            b.agentcontact = e.agentcontact;
            b.agentname = e.agentname;
            b.password = e.password;
            b.username = e.username;
            db.SaveChanges();
            return true;
        }

        public List<Agent> Get()
        {
            return db.Agents.ToList();
        }

        public Agent Get(int id)
        {
            return db.Agents.Find(id);
        }
    }
}
