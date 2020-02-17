using PeopleDirectory.DAL.Repositaries.IRepositaries;
using PeopleDirectory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace PeopleDirectory.DAL.Repositaries
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(PeopleContext context)
            : base(context)
        {
        }

        public PeopleContext PeopleContext
        {
            get { return Context as PeopleContext; }
        }

        public void Update(Client client)
        {
            //throw new NotImplementedException();
            //Context.Clients.Attach(client);
            //Context.Entry(client).State = EntityState.Modified;
            Context.Set<Client>().AddOrUpdate(client);
        }
    }
}