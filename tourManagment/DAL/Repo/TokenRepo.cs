using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TokenRepo : IRepository<Token, string, Token>
    {
        /*
        TMSAPIEntities db;

        public TokenRepo(TMSAPIEntities db)
        {
            this.db = db;
        }

        public void Add(Token e)
        {
            this.db.Tokens.Add(e);
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            var token = this.db.Tokens.FirstOrDefault(c => c.tokenaccess== id);
            db.Tokens.Remove(token);
            db.SaveChanges();
        }

        public void Edit(Token e)
        {
           var t = db.Tokens.FirstOrDefault(en => en.id==e.id);
            db.Entry(t).CurrentValues.SetValues(e);
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(c => c.tokenaccess== id);
        }
        */
        TMSAPIEntities1 db;

        public TokenRepo(TMSAPIEntities1 db)
        {
            this.db = db;
        }
        public Token Add(Token e)
        {
           db.Tokens.Add(e);
            db.SaveChanges();
            return e;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Token e)
        {
            var t = db.Tokens.FirstOrDefault(en => en.id == e.id);
            if(t != null)
            {
                db.Entry(t).CurrentValues.SetValues(e);
                db.SaveChanges() ;
                return true;
            }
            return false;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(c => c.tokenaccess == id);
        }
    }
}
