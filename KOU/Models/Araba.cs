using System.ComponentModel.DataAnnotations;

namespace KOU.Models

{
    public class Araba
    {
   
        public  int ArabaId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  string Marka { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  string Model { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(10, ErrorMessage = "Lütfen en az 7 karakterli bir plaka giriniz.", MinimumLength = 7)]
        public  string Plaka { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  string Renk { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(17, ErrorMessage = "Lütfen 17 karakterli bir şasi numarası giriniz.",MinimumLength =17)]
        public  string Sasi { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  string Problem { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int Kilometre { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  string Islem { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public decimal IslemUcret { get; set; }
    }
}
