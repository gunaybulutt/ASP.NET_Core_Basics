using aspnetcore_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_basics.Controllers;

//course
public class CourseController: Controller{

/*
    //course/index
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "Güzel Bir Kurs";
        kurs.Image= "1.jpeg";

        return View(kurs);
    }
*/

    public IActionResult Details(int? id)
    {
        if(id == null){
            //return Redirect("/course/list");
            return RedirectToAction("List","Course");
        }

        var kurs = Repository.GetById(id);

        return View(kurs);
    }

    //course/list
    public IActionResult List()
    {
        
        return View("CourseList", Repository.Courses);
    }

}