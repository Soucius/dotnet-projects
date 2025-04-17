using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller {
    List<Product> urunler = [
        new Product {
            Id = 1,
            urunBaslik = "iPhone 15",
            urunFiyat = 80000,
            urunResim = "i1.png",
            urunAciklama = "Guzel telefon",
            urunSatistaMi = true,
            IsHome = true
        },

        new Product {
            Id = 2,
            urunBaslik = "iPhone 16",
            urunFiyat = 90000,
            urunResim = "i2.png",
            urunAciklama = "Guzel telefon",
            urunSatistaMi = true,
            IsHome = true
        },

        new Product {
            Id = 3,
            urunBaslik = "iPhone 17",
            urunFiyat = 100000,
            urunResim = "i3.png",
            urunAciklama = "Guzel telefon",
            urunSatistaMi = true,
            IsHome = true
        },

        new Product {
            Id = 4,
            urunBaslik = "iPhone 18",
            urunFiyat = 110000,
            urunResim = "i4.png",
            urunAciklama = "Guzel telefon",
            urunSatistaMi = false,
            IsHome = false
        }
    ];

    public ActionResult Index() {
        List<Product> products = urunler.Where(p => p.IsHome).ToList();

        return View(products);
    }

    public ActionResult List() {
        return View(urunler);
    }

    public ActionResult Details(int id) {
        Product? product = urunler.Where(p => p.Id == id).FirstOrDefault();

        return View(product);
    }
}