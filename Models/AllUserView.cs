using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Webdevelopment_Project.Models
{
public class AllUserView
{
    public string UserId { get; set; }
    public string Name { get; set; }
    public IEnumerable<string> Roles { get; set; }
}
}