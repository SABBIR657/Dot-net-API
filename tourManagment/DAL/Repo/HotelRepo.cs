using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class HotelRepo : IHotelRepo<Hotel, int, bool>
    {
        TMSAPIEntities1 db;
        public HotelRepo()
        {
            db = new TMSAPIEntities1();
        }


        public bool Add(Hotel obj)
        {
            db.Hotels.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var Hotel = db.Hotels.Find(id);
            db.Hotels.Remove(Hotel);
            return db.SaveChanges() > 0;
        }

        public List<Hotel> Get()
        {
            return db.Hotels.ToList();
        }

        public Hotel Get(int id)
        {
            return db.Hotels.Find(id);
        }

        public bool Update(Hotel obj)
        {
            var ext = db.Hotels.Find(obj.hotelid);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }




    }
}
