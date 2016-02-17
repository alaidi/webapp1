using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public string Id { get; set; }
        [Display(Name = "Full Name ")]
        public string FullName { get; set; }
        [Display(Name = "Student Status")]
        public int StudentStatus { get; set; }
        public List<StudentStatus> StudentStatusList { get; set; }
    }
    public class StudentStatus
    {
        public string ID { get; set; }
        public string Type { get; set; }
    }
}