using dotnet_basics.Models;
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
        Product urun1 = new Product();

        urun1.urunBaslik = "Samsung S24 Ultra";
        urun1.urunAciklama = "Samsung Galaxy S24 Ultra 512GB 12GB Ram (Samsung Turkiye Garantili) Siyah";
        urun1.urunFiyat = 70000;
        urun1.urunResim = "samsung-s24.jpg";
        urun1.urunSatistaMi = false;

        return View(urun1);
    }
}