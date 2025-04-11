using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class HomeController: Controller {
    public string Index() {
        return "Index";
    }

    public string About() {
        return "about";
    }

    public string Contact() {
        return "Contact";
    }
}