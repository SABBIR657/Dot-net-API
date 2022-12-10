using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HotelService
    {
        public static List<HotelModel> Get()
        {
            var dbdata = DataAccessFactory.HotelDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Hotel, HotelModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<HotelModel>>(dbdata);
            return data;
        }
        public static HotelModel Get(int id)
        {
            var dbdata = DataAccessFactory.HotelDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Hotel, HotelModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<HotelModel>(dbdata);
            return data;
        }
        public static bool Add(HotelModel dto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<HotelModel, Hotel>();
                cfg.CreateMap<Hotel, HotelModel>();
            });
            var mapper = new Mapper(config);
            var group = mapper.Map<Hotel>(dto);
            var result = DataAccessFactory.HotelDataAccess().Add(group);
            return result;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.HotelDataAccess().Delete(id);
        }

        public static void Update(HotelModel dto)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<HotelModel, Hotel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Hotel>(dto);
            DataAccessFactory.HotelDataAccess().Update(data);
        }
    }
}
