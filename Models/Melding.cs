using System;
using System.ComponentModel.DataAnnotations;

public class Melding
{
    [Key]
    public int MeldingId { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string Ontvanger { get; set; }

    [Required]
    public string Titel { get; set; }

    [Required]
    public DateTime Datum { get; set; }

    public string Inhoud { get; set; }

    [Required]
    public bool IsAfgehandeld { get; set; }

    public int AfsrpaakId { get; set; }
    
}