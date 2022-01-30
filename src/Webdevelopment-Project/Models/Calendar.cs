using System.Collections.Generic;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Models{

public class Calendar
{
    public int Id { get; set; }

    public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    public ICollection<Event> Events { get; set; }
    
}
}