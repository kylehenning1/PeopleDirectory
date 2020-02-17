using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleDirectory.DAL.Repositaries.IRepositaries
{
    interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        //IAdminRepository Admins { get; }
        void Save();
    }
}