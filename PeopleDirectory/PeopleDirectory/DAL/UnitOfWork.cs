using PeopleDirectory.DAL.Repositaries;
using PeopleDirectory.DAL.Repositaries.IRepositaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleDirectory.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PeopleContext _db;

        public UnitOfWork(PeopleContext db)
        {
            _db = db;
            Clients = new ClientRepository(_db);
        }

        public IClientRepository Clients { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}