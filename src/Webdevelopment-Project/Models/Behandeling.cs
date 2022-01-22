using System;
using System.ComponentModel.DataAnnotations.Schema;
using Webdevelopment_Project.Models;

public class Behandeling
{
    public int Id {get;set;}
    public string Omschrijving {get;set;}
    public DateTime Datum {get;set;}
    public string Email {get;set;}
    

    [ForeignKey("ApplicationUser")]
    public string ApplicationUserID { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
}