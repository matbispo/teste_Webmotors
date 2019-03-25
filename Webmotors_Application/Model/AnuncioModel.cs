using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmotors.Application.Model
{
    public class AnuncioModel
    {
        [Key]
        public int ID { get; set; }

            [Display(Name = "marca")]
            [Required(ErrorMessage = "Campo Obrigatorio")]
            [StringLength(45, ErrorMessage = "Limite de 45 caracteres")]
            public string marca { get; set; }

            [Display(Name = "Modelo")]
            [Required(ErrorMessage = "Campo Obrigatorio")]
            [StringLength(45, ErrorMessage = "Limite de 45 caracteres")]
            public string modelo { get; set; }

            [Display(Name = "Versão")]
            [Required(ErrorMessage = "Campo Obrigatorio")]
            [StringLength(45, ErrorMessage = "Limite de 45 caracteres")]
            public string versao { get; set; }

        //public int marca { get; set; }
        //public int modelo { get; set; }
        //public int versao { get; set; }

        [Display(Name = "Ano")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        //[StringLength(4, ErrorMessage = "Limite de 4 caracteres"), MinLength(2, ErrorMessage = "Minmo de 2 caracteres")]
        public int ano { get; set; }

        [Display(Name = "Quilometragem")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public int quilometragem { get; set; }

        [Display(Name = "Observação")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string observacao { get; set; }
    }
}
