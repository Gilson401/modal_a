using System.ComponentModel.DataAnnotations;

namespace modalmais_a.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

     [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(60, ErrorMessage = "Campo deve ter 3 a 6 caracters")]
         public string Email {get; set;}

        
        // [MaxLength(60, ErrorMessage = "Campo deve ter 3 a 6 caracters")]
        // [MinLength(3, ErrorMessage = "Campo deve ter 3 a 6 caracters")]
        public string Cartao {get; set;}
    }
}