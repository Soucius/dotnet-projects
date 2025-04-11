using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller {
    public string Index() {
        return "Products/Index";
    }

    public string List() {
        return "Products/List";
    }

    public string Details() {
        return "Products/Details";
    }
}