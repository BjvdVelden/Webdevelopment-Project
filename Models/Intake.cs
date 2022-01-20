using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webdevelopment_Project.Models;

public class Intake
{
    [Key]
    public int IntakeId { get; set; }   
    
    [Required]
    public string Voornaam { get; set; }

    [Required]
    public string Achternaam { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime GeboorteDatum { get; set; }

    [Required]
    public string BSN { get; set; }
    public string EmailVoogd { get; set; }

    [Required]
    public string Email { get; set; }

    public string GewensteHulpverlener{ get; set; }

    [DataType(DataType.Date)]
    public DateTime GewensteMoment { get; set; }

    public string Onderwerp { get; set; }

    public DateTime AanmaakDatum { get; set; }

    public bool IsAfgehandeld { get; set; }
  
}