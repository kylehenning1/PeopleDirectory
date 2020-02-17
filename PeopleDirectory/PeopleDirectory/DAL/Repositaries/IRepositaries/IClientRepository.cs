using PeopleDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleDirectory.DAL.Repositaries.IRepositaries
{
    public interface IClientRepository : IRepository<Client>
    {
        void Update(Client client);
    }
}