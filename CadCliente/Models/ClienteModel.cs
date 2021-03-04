using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace CadCliente.Models
{
    public class ClienteModel
    {
        [Key]
        [Display(Name = "Código")]
        public int ClienteId { get; set; }
        
        [Required(ErrorMessage ="Nome do Cliente é obrigatório")]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Data de Nascimento é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }
        
        [Required(ErrorMessage = "Campo Sexo é obrigatório")]
        [StringLength(1)]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [StringLength(10)]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [StringLength(300)]
        [Display(Name = "Rua")]
        public string Endereço { get; set; }

        [Display(Name = "Número")]
        public int? Numero { get; set; }

        [StringLength(300)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [StringLength(300)]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [StringLength(300)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [StringLength(2)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
    }
}
