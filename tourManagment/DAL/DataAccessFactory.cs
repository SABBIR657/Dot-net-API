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

        static TMSAPIEntities db = new TMSAPIEntities();
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

        




    }
}
