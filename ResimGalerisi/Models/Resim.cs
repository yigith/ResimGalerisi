using System.ComponentModel.DataAnnotations;

namespace ResimGalerisi.Models
{
    public class Resim
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Baslik { get; set; } = string.Empty;

        [MaxLength(255)]
        public string DosyaAd { get; set; } = string.Empty;
    }
}
