using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller {
    public ActionResult Index() {
        string[] kurslar = { "Javascript Kursu", "React Kursu", "Angular Kursu" };

        return View(kurslar);
    }

    public ActionResult List() {
        List<Product> urunler = new List<Product> {
            new Product {
                urunBaslik = "iPhone 15",
                urunFiyat = 80000,
                urunResim = "i1.png",
                urunAciklama = "Guzel telefon",
                urunSatistaMi = true
            },

            new Product {
                urunBaslik = "iPhone 16",
                urunFiyat = 90000,
                urunResim = "i2.png",
                urunAciklama = "Guzel telefon",
                urunSatistaMi = true
            },

            new Product {
                urunBaslik = "iPhone 17",
                urunFiyat = 100000,
                urunResim = "i3.png",
                urunAciklama = "Guzel telefon",
                urunSatistaMi = true
            },

            new Product {
                urunBaslik = "iPhone 18",
                urunFiyat = 110000,
                urunResim = "i4.png",
                urunAciklama = "Guzel telefon",
                urunSatistaMi = false
            }
        };

        return View(urunler);
    }

    public ActionResult Details() {
        Product urun1 = new Product() {
            urunBaslik = "Samsung S24 Ultra",
            urunAciklama = "Samsung Galaxy S24 Ultra 512GB 12GB Ram (Samsung Turkiye Garantili) Siyah",
            urunFiyat = 70000,
            urunResim = "samsung-s24.jpg",
            urunSatistaMi = false,
            stokAdeti = 10
        };

        return View(urun1);
    }
}