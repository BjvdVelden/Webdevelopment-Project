using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Administratie.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
 
namespace Administratie.Controllers
{
    public class ApiController : Controller
    {

        // ------------------------------------------Show All Clients------------------------------------------//
        public async Task<IActionResult> Index()
        {
            List<AdministratieModel> AdministratieList = new List<AdministratieModel>();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("sleutel", "094211521");

                string uri = "https://orthopedagogie-zmdh.herokuapp.com/clienten?sleutel?=094211521";

                HttpResponseMessage response = await client.GetAsync(uri);  

                using (var httpClient = new HttpClient())
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject(apiResponse).ToString();
                    AdministratieList = JsonConvert.DeserializeObject<List<AdministratieModel>>(jsonResult);
            }
            return View(AdministratieList);
        }

        // ------------------------------------------Get Client------------------------------------------ //
        public ViewResult GetClient() => View();
 
        [HttpPost]
        public async Task<IActionResult> GetClient(int id)
        {
            AdministratieModel client = new AdministratieModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://orthopedagogie-zmdh.herokuapp.com/clienten?=" + id + "sleutel?=094211521"))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        client = JsonConvert.DeserializeObject<AdministratieModel>(apiResponse);
                    }
                    else
                        ViewBag.StatusCode = response.StatusCode;
                }
            }
            return View(client);
        }

        //------------------------------------------Add Client------------------------------------------//
        public ViewResult AddClient() => View();
        [HttpPost]
        public async Task<IActionResult> AddClient(AdministratieModel client)
        {
            AdministratieModel receivedClient = new AdministratieModel();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(client), Encoding.UTF8, "application/json");
 
                using (var response = await httpClient.PostAsync("", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedClient = JsonConvert.DeserializeObject<AdministratieModel>(apiResponse);
                }
            }
            return View(receivedClient);
        }

        //------------------------------------------Remove Client------------------------------------------//
          public async Task<IActionResult> DeleteClient(int clientId)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("" + clientId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Index");
        }

        //------------------------------------------Edit Client------------------------------------------//
        public async Task<IActionResult> UpdateClient(int clientId)
        {
            AdministratieModel reservation = new AdministratieModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("" + clientId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<AdministratieModel>(apiResponse);
                }
            }
            return View(reservation);
        }
 
        [HttpPost]
        public async Task<IActionResult> UpdateClient(AdministratieModel client)
        {
            AdministratieModel receivedClient = new AdministratieModel();
            using (var httpClient = new HttpClient())
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(client.clientid.ToString()), "Id");
                content.Add(new StringContent(client.volledigenaam), "volledigenaam");
                content.Add(new StringContent(client.IBAN), "IBAN");
                //content.Add(new StringContent(client.BSN), "BSN");
                content.Add(new StringContent(client.gebdatum), "gebdatum");
 
                using (var response = await httpClient.PutAsync("", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedClient = JsonConvert.DeserializeObject<AdministratieModel>(apiResponse);
                }
            }
            return View(receivedClient);
        }
    }
    
}
