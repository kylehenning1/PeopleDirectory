using PeopleDirectory.DAL;
using PeopleDirectory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace PeopleDirectory.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PeopleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PeopleContext context)
        {
            #region Add Clients
            var clients = new List<Client>
            {
                new Client
                {
                    id= Guid.NewGuid(),
                    Name = "Joe",
                    Surname = "Soap",
                    ProfilePic = "https://www.w3schools.com/howto/img_avatar.png",
                    MobileNumber = "0721435967",
                    Gender = "Male",
                    Email = "joesoap@gmail.com",
                    Location = "Vodka State3, Russia"
                },
                new Client
                {
                    id= Guid.NewGuid(),
                    Name = "Sandra",
                    Surname = "Beach",
                    ProfilePic = "https://www.w3schools.com/howto/img_avatar2.png",
                    MobileNumber = "0725235456",
                    Gender = "Female",
                    Email = "beach@hotmail.com",
                    Location = "Cape Town, South Africa"
                },
                new Client
                {
                    id= Guid.NewGuid(),
                    Name = "Taylor",
                    Surname = "Jayne",
                    ProfilePic = "https://www.w3schools.com/w3images/avatar6.png",
                    MobileNumber = "0721435967",
                    Gender = "Male",
                    Email = "TJ@hotmail.com",
                    Location = "Cape Town, America"
                },
                new Client
                {
                    id= Guid.NewGuid(),
                    Name = "Cynthia",
                    Surname = "Lopez",
                    ProfilePic = "https://www.w3schools.com/w3images/avatar6.png",
                    MobileNumber = "070493522",
                    Gender = "Female",
                    Email = "cynth@gmail.com",
                    Location = "Cape Town, South Africa"
                },
                new Client
                {
                    id= Guid.NewGuid(),
                    Name = "Johnny",
                    Surname = "Topaz",
                    ProfilePic = "https://www.w3schools.com/w3images/avatar2.png",
                    MobileNumber = "082434697",
                    Gender = "Male",
                    Email = "JOJo@gmail.com",
                    Location = "Some Place 1, Australia"
                },
                new Client
                {
                    id= Guid.NewGuid(),
                    Name = "Gretchen",
                    Surname = "Saunders",
                    ProfilePic = "https://www.w3schools.com/w3images/avatar6.png",
                    MobileNumber = "0821436667",
                    Gender = "Prefer not to say",
                    Email = "gretch@gmail.com",
                    Location = "Some Place 2, Australia"
                }
            };

            foreach (var client in clients)
                context.Clients.AddOrUpdate(c => c.id, client);

            context.SaveChanges();

            #endregion

        }
    }
}