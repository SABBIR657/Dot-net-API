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
    public class UserService
    {
        public static List<UserDTO> GetUser()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var groups = mapper.Map<List<UserDTO>>(data);
            return groups;
        }
        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var group = mapper.Map<UserDTO>(data);
            return group;
        }
        public static UserDTO Add(UserDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var group = mapper.Map<User>(dto);
            var result = DataAccessFactory.UserDataAccess().Add(group);
            return mapper.Map<UserDTO>(result);
        }
        public static bool Delete(int id)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var group = mapper.Map<User>(id);
            var result = DataAccessFactory.UserDataAccess().Delete(id);
            return result;
        }
    }
}
