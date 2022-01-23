using Webdevelopment_Project.Models;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;


namespace Webdevelopment_Project.Controllers
{

    public class ApiController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public Administratie administratie { get; set; }
        public ApiController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        public async Task<IActionResult> Index()
        {
            //Maakt request
            var sleutel = "&sleutel=094211521";
            var clientid = "?clientid=814380";

            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://orthopedagogie-zmdh.herokuapp.com/clienten"+ clientid + sleutel);


            //Maakt de client
            var client = _clientFactory.CreateClient();
            //voegt aan header toe
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            // verstuurd request
            var response = await client.SendAsync(request);

            //deserialize request
            if(response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                 administratie = await JsonSerializer.DeserializeAsync<Administratie>(responseStream);
                
            }
            else
            {
                administratie = new Administratie();
            }
            return View(administratie);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(Administratie gebruiker)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://orthopedagogie-zmdh.herokuapp.com/clienten?sleutel=094211521");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<Administratie>("https://orthopedagogie-zmdh.herokuapp.com/clienten?sleutel=094211521", gebruiker);
                postTask.Wait();
                var result = postTask.Result;


                if (result.IsSuccessStatusCode)
                {
                    var responseStream = result.Content.ReadAsStringAsync();
                    ViewBag.message = responseStream;

                    return RedirectToAction("Index");
                }
            }

            return View();
        }


        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {

                var sleutel = "&sleutel=094211521";
                var clientid = "?clientid=" + id;
                client.BaseAddress = new Uri("https://orthopedagogie-zmdh.herokuapp.com/clienten" + clientid + sleutel);

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("clienten/" + clientid);
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }


















        public string zoekId(string input)
        {
            if (!String.IsNullOrEmpty(input))
                return "Please welcome " + input + ".";
            else
                return "Please enter your name.";
        }

    /*    private void Authenticate()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://orthopedagogie-zmdh.herokuapp.com/clienten?clientid=10250");
        }*/

    }
}
