using ResimGalerisi.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ResimGalerisi.Models
{
    public class ResimViewModel
    {
        public string? Ara { get; set; }

        [MaxLength(100, ErrorMessage = "{0} en fazla {1} karakterden oluşabilir.")]
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Baslik { get; set; } = string.Empty;

        [GecerliResim(MaksimumDosyaBoyutuMb = 1)]
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public IFormFile Dosya { get; set; } = null!;

        public List<Resim> Resimler { get; set; } = new();
    }
}
