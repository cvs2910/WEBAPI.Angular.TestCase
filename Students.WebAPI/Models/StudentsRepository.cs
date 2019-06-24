using Newtonsoft.Json;
using Students.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;

namespace APM.WebAPI.Models
{
    /// <summary>
    /// Stores the data in a json file so that no database is required for this
    /// sample application
    /// </summary>
    public class StudentsRepository
    {
        /// <summary>
        /// Retorna la lista de estudientes.
        /// </summary>
        /// <returns></returns>
        internal List<Student> Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/students.json");

            var json = System.IO.File.ReadAllText(filePath);

            var Students = JsonConvert.DeserializeObject<List<Student>>(json);

            return Students;
        }
    }
}
