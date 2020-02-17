using PeopleDirectory.DAL;
using PeopleDirectory.DAL.Repositaries.IRepositaries;
using PeopleDirectory.Helpers;
using PeopleDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleDirectory.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        private readonly IUnitOfWork unitOfWork;

        public AdminController()
        {
            unitOfWork = new UnitOfWork(new PeopleContext());
        }

        // GET: Admin
        public ActionResult Index()
        {
            var clients = unitOfWork.Clients.GetAll();

            return View(clients);
        }

        // GET: Admin/Details/5
        public ActionResult Details(Guid id)
        {
            var client = unitOfWork.Clients.Get(id);

            return View(client);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Client c = new Client()
                {
                    id = Guid.NewGuid(),
                    Name = Request.Form["Name"],
                    Surname = Request.Form["Surname"],
                    ProfilePic = Request.Form["ProfilePic"],
                    MobileNumber = Request.Form["MobileNumber"],
                    Gender = Request.Form["Gender"],
                    Email = Request.Form["Email"],
                    Location = Request.Form["Location"]
                };

                unitOfWork.Clients.Add(c);
                unitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(Guid id)
        {
            var client = unitOfWork.Clients.Get(id);

            return View(client);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Edit(Guid id, FormCollection collection)
        {
            try
            {
                List<Client> list = new List<Client>();
                Client postEditedClient = new Client()
                {
                    id = id,
                    Name = Request.Form["Name"],
                    Surname = Request.Form["Surname"],
                    ProfilePic = Request.Form["ProfilePic"],
                    MobileNumber = Request.Form["MobileNumber"],
                    Gender = Request.Form["Gender"],
                    Email = Request.Form["Email"],
                    Location = Request.Form["Location"]
                };

                Client preEditClient = unitOfWork.Clients.Get(id);

                if (postEditedClient != preEditClient)
                {
                    list.Add(preEditClient);
                    list.Add(postEditedClient);
                    await EmailHelper.sendEmailAsync(list);
                }

                unitOfWork.Clients.Update(postEditedClient);
                unitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(Guid id)
        {
            var client = unitOfWork.Clients.Get(id);

            return View(client);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                var client = unitOfWork.Clients.Get(id);
                unitOfWork.Clients.Remove(client);
                unitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}