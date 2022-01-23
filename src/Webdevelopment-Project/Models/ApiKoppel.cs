using System.ComponentModel.DataAnnotations;

namespace Webdevelopment_Project.Models
{
    public class ApiKoppel
    {
        [Key]
        public int clientid { get; set; }
        public string volledigenaam { get; set; }
    }
}