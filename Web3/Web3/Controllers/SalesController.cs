using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web3.Controllers
{
    [Route("api/[controller]")]
    public class SalesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            List<Models.Sale> sales = new List<Models.Sale>();
            sales.Add(new Models.Sale() { Id = 1, Title = "Pembelian Xiaomi", Amount = 2000000, Deal = "New", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 2, Title = "Pembelian Oppo", Amount = 3400000, Deal = "Won", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 3, Title = "Pembelian Lenovo", Amount = 1800000, Deal = "Lose", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 4, Title = "Pembelian Asus", Amount = 8900000, Deal = "Won", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 5, Title = "Pembelian Windows Phone", Amount = 2600000, Deal = "New", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 6, Title = "Pembelian Apple iPhone", Amount = 13000000, Deal = "New", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 7, Title = "Pembelian Xiaomi", Amount = 2000000, Deal = "New", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 8, Title = "Pembelian Oppo", Amount = 3400000, Deal = "New", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 9, Title = "Pembelian Lenovo", Amount = 1800000, Deal = "Lose", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 10, Title = "Pembelian Asus", Amount = 8900000, Deal = "Won", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });

            return Json(sales);
            // return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Models.Sale Get(int id)
        {
            List<Models.Sale> sales = new List<Models.Sale>();
            sales.Add(new Models.Sale() { Id = 1, Title = "Pembelian Xiaomi", Amount = 2000000, Deal = "New", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 2, Title = "Pembelian Oppo", Amount = 3400000, Deal = "Won", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 3, Title = "Pembelian Lenovo", Amount = 1800000, Deal = "Lose", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 4, Title = "Pembelian Asus", Amount = 8900000, Deal = "Won", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 5, Title = "Pembelian Windows Phone", Amount = 2600000, Deal = "New", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 6, Title = "Pembelian Apple iPhone", Amount = 13000000, Deal = "New", CustomerId = 1, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 7, Title = "Pembelian Xiaomi", Amount = 2000000, Deal = "New", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 8, Title = "Pembelian Oppo", Amount = 3400000, Deal = "New", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 9, Title = "Pembelian Lenovo", Amount = 1800000, Deal = "Lose", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });
            sales.Add(new Models.Sale() { Id = 10, Title = "Pembelian Asus", Amount = 8900000, Deal = "Won", CustomerId = 2, Description = "Pembelian satu unit handphone Xiaomi", OrderDate = new DateTime(2016, 9, 12), Percentage = 20 });

            var sale = sales.Where(item => item.Id == id).FirstOrDefault();
            return sale;
        }

        // POST api/<controller>
        [HttpPost]
        public Models.Sale Post(Models.Sale value)
        {
            try
            {
                return value;
            } catch (Exception ex)
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
