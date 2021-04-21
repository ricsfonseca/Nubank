using System;
using System.ComponentModel.DataAnnotations;

namespace Nubank.Application.ViewModels.Clientes
{
    public class ClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Idade inválida")]
        public int Idade { get; set; }

        public decimal Saldo { get; set; }
    }
}