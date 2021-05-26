using System.ComponentModel.DataAnnotations;

namespace modalmais_a.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }



        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(60, ErrorMessage = "Campo deve ter 3 a 6 caracters")]
        [MinLength(3, ErrorMessage = "Campo deve ter 3 a 6 caracters")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Campo deve ter até 1024 caracters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Preço maior que 1")]
        public decimal Price { get; set; }



        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
        public decimal CategoryId { get; set; }


public Category Category { get; set; }


    }
}