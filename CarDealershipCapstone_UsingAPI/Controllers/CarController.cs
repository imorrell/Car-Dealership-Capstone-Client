using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CarDealershipCapstone_UsingAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealershipCapstone_UsingAPI.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> SearchCar()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44348/");
            var response = await client.GetAsync($"api/CarDb/");
            //Install Microsoft.AspNet.WebApI.Client Nuget Package
            var cars = await response.Content.ReadAsAsync<List<Cars>>();
            return View(cars);
        }

        public async Task<IActionResult> SearchCarResults(string make, string model, string year, string color)
        {
            //use view bag to return vehicle make
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44348/");
            var response = await client.GetAsync($"api/CarDb/search?make={make}&model={model}&year={year}&color={color}");
            //Install Microsoft.AspNet.WebApI.Client Nuget Package
            var cars = await response.Content.ReadAsAsync<List<Cars>>();
            return View(cars);
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(Cars car)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44348/");
            //var employeeJSON = JsonConvert.SerializeObject(employee);
            var newCar = await client.PostAsJsonAsync("api/CarDb", car);
            return View(newCar);
        }

        //[HttpPut]
        //public async Task<IActionResult> UpdateCar(int id)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:44348/");
        //    //var employeeJSON = JsonConvert.SerializeObject(employee);
        //    var newCar = await client.PostAsJsonAsync("api/CarDb", car);
        //    return View(newCar);
        //}


    }
}