using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Webdevelopment_Project.Models;

public class ClientModel : IdentityUser
{
    public string Naam{get;set;}
    public string Woonplaats{get;set;}
    public string Postcode{get;set;}
    public string Geboortedatum{get;set;}

    public ICollection<HulpverlenerModel> Hulpverlener { get; set; }
}