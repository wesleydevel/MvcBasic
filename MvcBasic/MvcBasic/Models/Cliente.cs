using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "Preencher campo nome")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        [Display(Name = "Sobrenome do cliente")]
        [Required(ErrorMessage = "Preencher campo sobrenome")]
        public string SobreNome { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name ="Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres execedido")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage ="Preencher o campo E-mail")]
        [EmailAddress(ErrorMessage = "E-mail preenchido no formato invalido")]
        public string Email { get; set; }

    }
}