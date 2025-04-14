using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;
public class CourseController: Controller {
    public ActionResult Index() {
        return View();
    }

    public ActionResult Details() {
        int kursSaati = 40;
        string[] kursAdlari = ["Javascript Kursu", "React Kursu"];

        ViewData["kursSaati"] = kursSaati;

        return View(kursAdlari);
    }

    public ActionResult List() {
        string[] kursAdlari = ["Javascript Kursu", "React Kursu"];
        string[] kursAciklamalari = ["Javascript Kurs Aciklamasi", "React Kurs Aciklamasi"];
        string[] kursResimleri = ["1.jpg", "2.jpg"];

        ViewData["kursAdi1"] = kursAdlari[0];
        ViewData["kursAdi2"] = kursAdlari[1];

        ViewData["kursAciklama1"] = kursAciklamalari[0];
        ViewData["kursAciklama2"] = kursAciklamalari[1];

        ViewData["kursResim1"] = kursResimleri[0];
        ViewData["kursResim2"] = kursResimleri[1];

        return View();
    }
}