using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Webdevelopment_Project.Models;

public class Group
{
	public int Id { get; set; }
    public string Name { get; set; }
    public virtual GroupChat GroupChat { get; set; }
    public List<IdentityUser> Users { get; set; }
}