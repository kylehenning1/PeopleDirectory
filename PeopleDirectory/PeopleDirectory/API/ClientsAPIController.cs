using PeopleDirectory.DAL;
using PeopleDirectory.DAL.Repositaries.IRepositaries;
using PeopleDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PeopleDirectory.API
{
    public class ClientsAPIController : ApiController
    {

        private readonly IUnitOfWork unitOfWork;

        public ClientsAPIController()
        {
            unitOfWork = new UnitOfWork(new PeopleContext());
        }

        // GET: api/ClientsAPI
        public IEnumerable<Client> Get()
        {
            IEnumerable<Client> clients = unitOfWork.Clients.GetAll();

            return clients;
        }

        // GET: api/ClientsAPI/5
        public Client Get(Guid id)
        {
            Client client = unitOfWork.Clients.Get(id);

            return client;
        }
    }
}