using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
public class CourseController: Controller {
    public ActionResult Index() {
        return View();
    }

    public ActionResult Details() {
        Course kurs1 = new Course();
        kurs1.Title = "Django Kursu";
        kurs1.Image = "1.jpg";

        return View(kurs1);
    }

    public ActionResult List() {
        // Course[] kurslar = [kurs1, kurs2, kurs3];
        List<Course> kurslar = new List<Course> {
            new Course {
                Title = "Javascript Kursu",
                Image = "1.jpg"
            },

            new Course {
                Title = "React Kursu",
                Image = "2.jpg"
            },

            new Course {
                Title= "Angular Kursu",
                Image= "3.jpg"
            },

            new Course {
                Title= "Nodejs Kursu",
                Image= "4.jpg"
            }
        };

        return View(kurslar);
    }
}