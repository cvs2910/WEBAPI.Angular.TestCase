using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.WebAPI.Models
{
    public class Student
    {
        public string StudentName {get; set; }
        public int Language { get; set; }
        public int Science { get; set; }
        public int SocialStudies { get; set; }
        public int Math { get; set; }
        //public List<Class> Classes { get; set; }
    }
}