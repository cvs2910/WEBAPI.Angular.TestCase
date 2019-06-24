using APM.WebAPI.Models;
using Students.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Students.WebAPI.Controllers
{
    [EnableCorsAttribute("http://localhost:52885", "*","*")]
    public class StudentsController : ApiController
    {
        // GET: api/Students
        public IEnumerable<Student> Get()
        {
            var studentsRepository = new StudentsRepository();

            return studentsRepository.Retrieve();
        }
    }
}
