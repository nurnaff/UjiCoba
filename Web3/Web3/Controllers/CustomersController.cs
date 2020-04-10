using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web3.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            List<Models.Customer> customers = new List<Models.Customer>();
            customers.Add(new Models.Customer() { Id = 1, Nama = "Puja Pramudya", Address = "JL A. Yani No 669", Company = "Radya Labs Teknologi", PhoneNumber = "085265204094", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/458905232135565312/v3PFrCLy_400x400.png" });
            customers.Add(new Models.Customer() { Id = 2, Nama = "Tito Daniswara", Address = "JL Pasteur No 43", Company = "CV Anugrah Prima", PhoneNumber = "082263204094", Latitude = -6.167987, Longitude = 106.756685, ProfileImageUrl = "https://pbs.twimg.com/profile_images/530372486945189889/tj3XQ8xi_400x400.jpeg" });
            customers.Add(new Models.Customer() { Id = 3, Nama = "Albilaga", Address = "JL Sido Luhur No 43", Company = "Raion Studio", PhoneNumber = "081163234094", Latitude = -6.137277, Longitude = 106.765563, ProfileImageUrl = "https://pbs.twimg.com/profile_images/531025242747969536/vhoWFuuD.png" });
            customers.Add(new Models.Customer() { Id = 4, Nama = "Faizal Hitobeli", Address = "JL Johari No 13", Company = "PT Master System Informatika", PhoneNumber = "081163231014", Latitude = -6.124416, Longitude = 106.776081, ProfileImageUrl = "https://pbs.twimg.com/profile_images/2817469495/93109782ad239625a31343dee4f6ddd1_400x400.jpeg" });
            customers.Add(new Models.Customer() { Id = 5, Nama = "Rendy Faqot", Address = "JL Taman Kopo Indah", Company = "PT BSP Prima", PhoneNumber = "081763231012", Latitude = -6.941151, Longitude = 107.560527, ProfileImageUrl = "https://pbs.twimg.com/profile_images/731307445604114433/LBUwu6VS.jpg" });
            customers.Add(new Models.Customer() { Id = 6, Nama = "Irfan Afif", Address = "JL Ciheulang", Company = "PT IT Bersama", PhoneNumber = "081863236012", Latitude = -6.936504, Longitude = 107.648304, ProfileImageUrl = "https://pbs.twimg.com/profile_images/3114319086/7385720f1d854e6f1c1163fedb4c348a.jpeg" });
            customers.Add(new Models.Customer() { Id = 7, Nama = "Hari Bagus", Address = "JL Denpasar", Company = "PT Cimanuk Solution", PhoneNumber = "081863236012", Latitude = -6.936504, Longitude = 107.648304, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1418745373/hari.png" });
            customers.Add(new Models.Customer() { Id = 8, Nama = "Ade Rifaldi", Address = "JL Jakarta", Company = "PT Rekadia Solution", PhoneNumber = "082263236072", Latitude = -6.936504, Longitude = 107.648304, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1227963900/IMG-20110125-00063_400x400.jpg" });

            return Json(customers);
            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Models.Customer Get(int id)
        {
            List<Models.Customer> customers = new List<Models.Customer>();
            customers.Add(new Models.Customer() { Id = 1, Nama = "Puja Pramudya", Address = "JL A. Yani No 669", Company = "Radya Labs Teknologi", PhoneNumber = "085265204094", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/458905232135565312/v3PFrCLy_400x400.png" });
            customers.Add(new Models.Customer() { Id = 2, Nama = "Tito Daniswara", Address = "JL Pasteur No 43", Company = "CV Anugrah Prima", PhoneNumber = "082263204094", Latitude = -6.167987, Longitude = 106.756685, ProfileImageUrl = "https://pbs.twimg.com/profile_images/530372486945189889/tj3XQ8xi_400x400.jpeg" });
            customers.Add(new Models.Customer() { Id = 3, Nama = "Albilaga", Address = "JL Sido Luhur No 43", Company = "Raion Studio", PhoneNumber = "081163234094", Latitude = -6.137277, Longitude = 106.765563, ProfileImageUrl = "https://pbs.twimg.com/profile_images/531025242747969536/vhoWFuuD.png" });
            customers.Add(new Models.Customer() { Id = 4, Nama = "Faizal Hitobeli", Address = "JL Johari No 13", Company = "PT Master System Informatika", PhoneNumber = "081163231014", Latitude = -6.124416, Longitude = 106.776081, ProfileImageUrl = "https://pbs.twimg.com/profile_images/2817469495/93109782ad239625a31343dee4f6ddd1_400x400.jpeg" });
            customers.Add(new Models.Customer() { Id = 5, Nama = "Rendy Faqot", Address = "JL Taman Kopo Indah", Company = "PT BSP Prima", PhoneNumber = "081763231012", Latitude = -6.941151, Longitude = 107.560527, ProfileImageUrl = "https://pbs.twimg.com/profile_images/731307445604114433/LBUwu6VS.jpg" });
            customers.Add(new Models.Customer() { Id = 6, Nama = "Irfan Afif", Address = "JL Ciheulang", Company = "PT IT Bersama", PhoneNumber = "081863236012", Latitude = -6.936504, Longitude = 107.648304, ProfileImageUrl = "https://pbs.twimg.com/profile_images/3114319086/7385720f1d854e6f1c1163fedb4c348a.jpeg" });
            customers.Add(new Models.Customer() { Id = 7, Nama = "Hari Bagus", Address = "JL Denpasar", Company = "PT Cimanuk Solution", PhoneNumber = "081863236012", Latitude = -6.936504, Longitude = 107.648304, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1418745373/hari.png" });
            customers.Add(new Models.Customer() { Id = 8, Nama = "Ade Rifaldi", Address = "JL Jakarta", Company = "PT Rekadia Solution", PhoneNumber = "082263236072", Latitude = -6.936504, Longitude = 107.648304, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1227963900/IMG-20110125-00063_400x400.jpg" });

            var customer = customers.Where(item => item.Id == id).FirstOrDefault();
            return customer;
            //return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public Models.Customer Post(Models.Customer value)
        {
            try
            {
                return value;
            }catch(Exception ex)
            {
                return null;
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
