using System;
using System.ComponentModel.DataAnnotations;
using Webdevelopment_Project.Models;

public class Message
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Text { get; set; }

    [Required]
    public DateTime When { get; set; }

    public string UserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
}