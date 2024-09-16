using System.ComponentModel.DataAnnotations;

namespace KOU.Models

{
    public class ArabaSahibi
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string ArabaSahibiAdi { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int ArabaId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public decimal Borc { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public decimal Alacak { get; set; }
    }
}
