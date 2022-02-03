using System;
using System.ComponentModel.DataAnnotations;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Models
{
    public class assistentHulpverlenerKoppel{
    
    [Key]
    public int idKoppel {get; set;}
    public string mailHulpverlener{get; set;}
    public string mailAssistent{get;set;}

    }
}