﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap03.Web.MVC.Models
{
    public class Time
    {
        public string Nome { get; set; }

        [Display (Name = "Pontuação")]
        public int Pontuacao { get; set; }
   
        [Display (Name = "Classificação")]
        public int Classificacao { get; set; }

        [Display (Name = "Patrocínio")]
        public bool Patrocinio { get; set; }

        [Display(Name = "Descricao") ]
        public string Descricao { get; set; }

        [Display (Name = "Data Fundação")]
        public DateTime DataFundacao { get; set; }
        public string Liga { get; set; }  
    }
}