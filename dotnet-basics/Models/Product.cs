namespace dotnet_basics.Models;

public class Product {
    public string urunBaslik { get; set; } = null!;
    public string urunAciklama { get; set; } = null!;
    public double urunFiyat { get; set; }
    public string? urunResim { get; set; }
    public bool urunSatistaMi { get; set; }
    public int stokAdeti { get; set; }
}