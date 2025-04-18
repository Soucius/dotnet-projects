using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class UrunController: Controller {
    public ActionResult Index() {
        return View();
    }
}