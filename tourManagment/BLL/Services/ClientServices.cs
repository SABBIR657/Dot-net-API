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
    public class ClientServices
    {
        TMSAPIEntities1 db = new TMSAPIEntities1();

        public static PackageModel Get(int uid)
        {
            var u = DataAccessFactory.PacakgeDataAccess().Get(uid);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Package, PackageModel>());
            Mapper mapper= new Mapper(config);
            var d = mapper.Map<PackageModel>(u);
            return d;
        }

        public static List<PackageModel>Get()
        {
            var u = DataAccessFactory.PacakgeDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Package, PackageModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<List<PackageModel>>(u);
            return d;
        }

        public static List<ClientModel> Getclient()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Client, ClientModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ClientModel>>(DataAccessFactory.ClientDataAccess().Get());
            return data;
        }

        public static void Create(ClientModel c)
        {
            /*
            Client d = new Client()
            {
                clientemail = c.clientemail,
                clientname = c.clientname,
                clientcontact = c.clientcontact,
                username = c.username,
            };
            DataAccessFactory.ClientDataAccess().Add(d);

            return true;
            */

            var config = new MapperConfiguration(e =>
            {
                e.CreateMap<ClientModel, Client>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Client>(c);
            DataAccessFactory.ClientDataAccess().Add(data);
                }

        public static bool Delete(int id)
        {
            DataAccessFactory.ClientDataAccess().Delete(id);
            return true;
        }


        public static bool Edit(ClientModel c)
        {
            Client d = new Client()
            {
                clientid = c.clientid,
                clientemail= c.clientemail,
                clientname = c.clientname,
                clientcontact = c.clientcontact,
                password = c.password,
                username= c.username,
            };
            DataAccessFactory.ClientDataAccess().Edit(d);

            return true;
            
        }

        public static bool AddPackage(BookingModel c)
        {
            Booking d = new Booking()
            {
                bookingid = c.bookingid,
                packageid = c.packageid,
                clientid = c.clientid,
            };
            DataAccessFactory.BookingDataAccess().AddPackage(d);
            return true;
        }

        public static bool DeletePackage(int id)
        {
            DataAccessFactory.BookingDataAccess().DeletePackage(id);
            return true;
        }

        public static BookingModel GetPackage(int uid)
        {
            var u = DataAccessFactory.BookingDataAccess().GetPackage(uid);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<BookingModel>(u);


            return d;
        }

        public static List<BookingModel> GetPackage()
        {
            var u = DataAccessFactory.BookingDataAccess().GetPackage();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<List<BookingModel>>(u);

            return d;
        }
    }
}
