using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public String Nome { get; set; }
        public Filme Filme { get; set; }
    }
}