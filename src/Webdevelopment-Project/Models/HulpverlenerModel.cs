// public class Hulpverlener
// {
//     public int Id{get;set;}
//     public string Naam{get;set;}
//     public string Geboortedatum{get;set;}
//     public int Telefoonnummer{get;set;}
//     public string Emailadres{get;set;}
//     public string Specialisme{get;set;}
//     public Hulpverlener moderator{get;set;}

// }
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using  Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Models
{
 public class Hulpverlener: ApplicationUser{
        // public int id{get;set;}
        [ForeignKey("ApplicationUser")]
        public string ClientID{get;set;}
        public Client Client{get;set;}
    }
}