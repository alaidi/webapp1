using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> model = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                var student = new Student
                {
                    Id = i.ToString(),
                    FullName = "Student " + i,
                    StudentStatusList = new List<StudentStatus>
                    {
                        new StudentStatus {ID = "1", Type = "Present"},
                        new StudentStatus {ID = "2", Type = "Absent"},
                        new StudentStatus {ID = "3", Type = "Unrecorded"}
                    }
                };
                model.Add(student);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(List<Student> model)// problem is here
        {
            if (ModelState.IsValid)
            {
                //TODO: Save your model and redirect
            }
            return View(model);
        }
    }
}
