using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Execicio.Web.MVC.Models
{
    public class Refeicao
    {
        [Display (Name = "Nome da Refeição")]
        public string Nome { get; set; }
        [Display (Name = "Vegetariano")]
        public bool Vegetariano { get; set; }
        [Display(Name = "Bebida da refeição")]
        public string Bebida { get; set; }
    }
}