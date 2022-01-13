using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Administratie.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
 
namespace Administratie.Controllers
{
    public class ApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<AdministratieModel> AdministratieList = new List<AdministratieModel>();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("sleutel", "094211521");
                using (var response = await httpClient.GetAsync("https://orthopedagogie-zmdh.herokuapp.com/clienten"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    AdministratieList = JsonConvert.DeserializeObject<List<AdministratieModel>>(apiResponse);
                }
            }
            return View(AdministratieList);
        }
    }
}
