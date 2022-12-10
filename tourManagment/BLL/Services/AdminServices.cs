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
    public class AdminServices
    {
        public static List<AdminModel> Get()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Host, AdminModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AdminModel>>(DataAccessFactory.HostDataAccess().Get());
            return data;
        }

        public static void Create(AdminModel c)
        {
           

            var config = new MapperConfiguration(e =>
            {
                e.CreateMap<AdminModel, Host>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Host>(c);
            DataAccessFactory.HostDataAccess().Add(data);
        }

        public static bool Delete(int id)
        {
            DataAccessFactory.HostDataAccess().Delete(id);
            return true;
        }

        public static bool Edit(AdminModel c)
        {
            Host d = new Host()
            {
                hostid = c.hostid,
                address = c.address,
                email = c.email,
                mobilenumber = c.mobilenumber,
                password = c.password,
                username = c.username,
            };
            DataAccessFactory.HostDataAccess().Edit(d);

            return true;

        }

    }
}
