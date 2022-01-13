using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Webdevelopment_Project.Models{
public class HulpverlenerModel : IdentityUser
{
    public string Naam{get;set;}
    public string Geboortedatum{get;set;}
    public int Telefoonnummer{get;set;}
    public string Emailadres{get;set;}
    public string Specialisme{get;set;}
    public bool moderator{get;set;}
    public int ClientID { get; set; }
    
    public ClientModel Client { get; set; }
}
}