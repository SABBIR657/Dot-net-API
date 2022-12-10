using DAL.EF;
using DAL.Repo;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {

        static TMSAPIEntities1 db = new TMSAPIEntities1();
        public static IAuth AuthDataAccess()
        {
            return new AuthRepo(db);
        }

        public static IRepository<Client, int, bool> ClientDataAccess()
        {
            return new ClientRepo(db);
        }

        public static IPackageRepo<Package, int> PacakgeDataAccess()
        {
            return new packageRepo(db);
        }

        public static IBookingRepo<Booking, int> BookingDataAccess()
        {
            return new BookingRepo(db);
        }

        public static IRepository<Agent, int, bool> AgentDataAccess()
        {
            return new AgentRepo(db);

        }

        public static IRepo<User, int, User> UserDataAccess()
        {
            return new UserRepo();
        }

        public static IHotelRepo<Hotel, int, bool> HotelDataAccess()
        {
            return new HotelRepo();
        }

        public static IRepository<Host, int, bool> HostDataAccess()
        {
            return new AdminRepo(db);

        }

        public static IRepo<Login, string, Login> LoginDataAccess()
        {
            return new LoginRepo();
        }






    }
}
