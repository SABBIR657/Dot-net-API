using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AgentServices
    {
        public static List<AgentModel> Get()
        {
            var config = new MapperConfiguration(c => c.CreateMap<Agent, AgentModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AgentModel>>(DataAccessFactory.AgentDataAccess().Get());
            return data;
        }

        public static void Create(AgentModel c)
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
                e.CreateMap<AgentModel, Agent>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Agent>(c);
            DataAccessFactory.AgentDataAccess().Add(data);
        }

        public static bool Delete(int id)
        {
            DataAccessFactory.AgentDataAccess().Delete(id);
            return true;
        }

        
        public static bool Edit(AgentModel c)
        {
            Agent d = new Agent()
            {
                agentid = c.agentid,
                agentmail = c.agentmail,
                agentname = c.agentname,
                agentcontact = c.agentcontact,
                password = c.password,
                username = c.username,
            };
            DataAccessFactory.AgentDataAccess().Edit(d);

            return true;

        }
        

    }

}
