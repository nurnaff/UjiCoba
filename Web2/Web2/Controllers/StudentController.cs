using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web2.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            Models.Student[] students = new Models.Student[3];
            students[0] = new Models.Student("11211", "Nur", 1);
            students[1] = new Models.Student("11212", "Naff", 2);
            students[2] = new Models.Student("11213", "Iyah", 3);
            return Json(students);
            //return Json(new string[] { "Naff", "Andi" });
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Nako";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
