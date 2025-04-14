using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller {
    public ActionResult Index() {
        return View();
    }

    public ActionResult List() {
        return View();
    }

    public ActionResult Details() {
        string urunBaslik = "Samsung S24 Ultra";
        string urunAciklama = "Samsung Galaxy S24 Ultra 512GB 12GB Ram (Samsung Turkiye Garantili) Siyah";
        double urunFiyat = 70000;
        string urunResim = "samsung-s24.jpg";
        bool urunSatistaMi = false;

        ViewData["urunBaslik"] = urunBaslik;
        ViewData["urunAciklama"] = urunAciklama;
        ViewData["urunFiyat"] = urunFiyat;
        ViewData["urunResim"] = urunResim;
        ViewData["urunSatistaMi"] = urunSatistaMi;

        return View();
    }
}