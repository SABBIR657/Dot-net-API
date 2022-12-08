using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    
    public class AuthServices
    {
        public static TokenModel Authenticate(string username, string password)
        {
            var data = DataAccessFactory.AuthDataAccess().Authenticate(username, password);
            if (data != null)
            {
                TokenModel tokenModel = new TokenModel()
                {
                    id = data.id,
                    clientid = data.clientid,
                    tokenaccess = data.tokenaccess,
                    Createdat = data.Createdat,
                    Expireat = data.Expireat
                };
                return tokenModel;
            }
            return null;
        }
        public static bool CheckValidityToken(string token)
        {
            var authCheck = DataAccessFactory.AuthDataAccess().IsAuthenticate(token);
            return authCheck;
        }
        public static bool Logout(int uid)
        {
            var logout = DataAccessFactory.AuthDataAccess().Logout(uid);
            return logout;
        }
    }
    

    /*
    public static TokenModel Authenticate(string username, string password)
    {
        var user = DataAccessFactory.AuthDataAccess().Authenticate(username, password);
        if(user != null)
        {
            Token t = new Token();
            t.Createdat = DateTime.Now;
            t.clientid = user.clientid;
            t.id = user.id;
            t.Expireat = null;
            t.Tkey = Guid.NewGuid().ToString();
        }

        return null;
    }
    */
} 
