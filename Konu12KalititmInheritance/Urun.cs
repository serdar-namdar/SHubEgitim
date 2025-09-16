namespace Konu12KalitimInheritance
{
    public class Urun : OrtakOzellikler
    {
        public string? TeknikOzellikler { get; set; } // ? işareti bu alanın nullable yani boş bırakılabilir olmasını sağlar
        public decimal Fiyat { get; set; }
        public int Kdv { get; set; }
        public int Iskonto { get; set; }
    }
}
