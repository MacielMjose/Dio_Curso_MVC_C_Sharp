using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="O campo Descrição é Obrigatório")]
        [Range(1,10, ErrorMessage = "A quantidade máxima é 10")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        
        public Categoria categoria { get; set; }
    }
}
