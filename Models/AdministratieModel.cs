using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace Administratie.Models
{
    public class AdministratieModel
    {
        public int clientid { get; set; }
        public string volledigenaam { get; set; }
        public string IBAN { get; set; }
        public int BSN { get; set; }
        public string gebdatum{ get; set; }
    }

}
