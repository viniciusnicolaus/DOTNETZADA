using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public String Nome { get; set; }
        public double Duracao { get; set; }

        public int CategoriaId { get; set; }
        public IList<Categoria> Categoria { get; set; }

        public int CategoriaIndicativa { get; set; }
    }
}