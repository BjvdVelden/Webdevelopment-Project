using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser{
    [Key]
    public int BSN{get;set;}
    public string Naam{get;set;}
    public string Woonplaats{get;set;}
    public string Postcode{get;set;}
    public string Geboortedatum{get;set;}
    public List<ApplicationUser> Guides { get; set; }
    public List<ApplicationUser> GuidedBy { get; set; }
    public List<Group> Groups { get; set; }

}