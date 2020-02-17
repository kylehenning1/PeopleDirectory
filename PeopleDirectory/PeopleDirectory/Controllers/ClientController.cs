using PeopleDirectory.DAL;
using PeopleDirectory.DAL.Repositaries.IRepositaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleDirectory.Controllers
{
    public class ClientController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ClientController()
        {
            unitOfWork = new UnitOfWork(new PeopleContext());
        }

        // GET: Client
        public ActionResult Index(Guid id)
        {
            var client = unitOfWork.Clients.Get(id);

            return View(client);
        }
    }
}