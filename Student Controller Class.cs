using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity
{
    public class Student_Controller_Class : Controller
    {
        [HttpGet("api/studentrecord")]
        public object Get(string name)
        {
            return new
            {
                Message = $"student id, {name}.",
                time =  DateTime.Now
            };
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
