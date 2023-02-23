using System.ComponentModel.DataAnnotations;

namespace ResimGalerisi.Attributes
{
    public class GecerliResimAttribute : ValidationAttribute
    {
        public int MaksimumDosyaBoyutuMb { get; set; }

        public override bool IsValid(object? value)
        {
            IFormFile? file = value as IFormFile;

            if (file == null)
                return true;

            if (MaksimumDosyaBoyutuMb > 0 && file.Length > MaksimumDosyaBoyutuMb * 1024 * 1024)
            {
                ErrorMessage = $"Dosya boyutu {MaksimumDosyaBoyutuMb}MB'dan büyük.";
                return false;
            }
            else if (!file.ContentType.StartsWith("image/"))
            {
                ErrorMessage = "Geçersiz resim formatı.";
                return false;
            }

            return true;
        }
    }
}
