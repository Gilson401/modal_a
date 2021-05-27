using System.ComponentModel.DataAnnotations;

namespace modalmais_a.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo email é requerido")]
        [MaxLength(60, ErrorMessage = "Campo  até 60 caracteres")]
        public string Email { get; set; }

        public string Cartao { get; set; }
    }
}


