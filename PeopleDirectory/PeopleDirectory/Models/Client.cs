using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeopleDirectory.Models
{
    public class Client
    {
        public Client(string name, string surname, string profilePic, string mobileNumber, string gender, string email)
        {
            id = new Guid();
            Name = name;
            Surname = surname;
            ProfilePic = profilePic;
            MobileNumber = mobileNumber;
            Gender = gender;
            Email = email;
        }
        public Client()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Profile Pic")]
        public string ProfilePic { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}