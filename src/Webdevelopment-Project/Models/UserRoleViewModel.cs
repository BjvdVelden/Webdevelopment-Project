using System.Collections.Generic;

namespace Webdevelopment_Project.Models{
public class UserRolesViewModel
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string HulpverlenerEmail { get; set; }
    
    public IEnumerable<string> Roles { get; set; }
}
}