using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCproject.Models;

namespace MVCproject.Controllers
{
    
    //localhost:5000/course
    public class CourseController : Controller
    {
        //action method
        //localhost:5000/course/index => course/index.cshtml

        //public  ActionResult Detail(int id)
        //{
        //    return Content("id=" + id);
        //}

        public IActionResult Index()
        {
            
            return View();
        }

//localhost:5000/course/apply => course/apply.cshtml
        [HttpGet]
        public IActionResult Apply()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        

        [HttpPost]
        //FORMDAN SERVER'A BİLGİ GÖNDERİYORUZ
        // Name=value&Email=value&phone=value&confirm=value
        public IActionResult Apply(Student student)
        {
            // database kayıt
            //Model Binding-Model Bağlama
            if (ModelState.IsValid) {
                Repository.AddStudent(student);
                return View("Thanks", student);

            }
            else {

                return View(student);
            }
        }
        
        public IActionResult Details()
        {
            // name: "Core Mvc Kursu"
            // description: "güzel bir kurs"
            // isPublished: true
            
            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }   
        //localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            var students = Repository.Students.Where(i=>i.Confirm == true);
            return View(students);
        }

    }
}