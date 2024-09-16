using System.ComponentModel.DataAnnotations;

namespace KOU.Models
{
    public class Parca
    {
        public  int ParcaId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  string ParcaIsim { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  int ParcaStok { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public  string ParcaTur { get; set; }
    }
}
