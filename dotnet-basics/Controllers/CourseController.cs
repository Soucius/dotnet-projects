using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
public class CourseController: Controller {
    public string List() {
        return "List";
    }

    public string Details() {
        return "Details";
    }
}