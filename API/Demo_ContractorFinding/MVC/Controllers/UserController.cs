using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7294/");
        HttpClient client;

        public UserController()
        {
            client= new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<UserViewModel>modelList= new List<UserViewModel>();
            HttpResponseMessage responseMessage = client.GetAsync(client.BaseAddress + "/user").Result;
            if(responseMessage.IsSuccessStatusCode)
            {
                string data =responseMessage.Content.ReadAsStringAsync().Result; 
                modelList=JsonConvert.DeserializeObject<List<UserViewModel>>(data); 
            }
            return View(modelList);
        }
    }
}
