using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Web2.Controllers.Models
{
    public class Student
    {
        public Student(string nis,string name,int grade)
        {
            NIS = nis;
            Nama = name;
            Grade = grade;
        }
    [JsonProperty("nis")]
        public string NIS { get; set; }
        public string Nama { get; set; }
        public int Grade { get; set; }
    }
}
