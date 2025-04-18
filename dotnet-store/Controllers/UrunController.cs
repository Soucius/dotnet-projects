using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class UrunController: Controller {
    private readonly DataContext _context;

    public UrunController(DataContext context) {
        _context = context;
    }

    public ActionResult Index() {
        var urunler = _context.Urunler.ToList();

        return View(urunler);
    }
}