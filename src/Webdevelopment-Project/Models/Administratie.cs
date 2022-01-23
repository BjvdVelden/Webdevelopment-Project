using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace Webdevelopment_Project.Models
{
    public class Administratie
    {
        public int clientid { get; set; }
        public string volledigenaam { get; set; }
        public string IBAN { get; set; }
        public string BSN { get; set; }
        public string gebdatum { get; set; }

    }
}
