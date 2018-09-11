﻿using Fiap05.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Persistencia
{
    public class FiapBankContext : DbContext
    {
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CartaoReal> CartoesReais { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CartaoVirtual> CartoesVirtuais { get; set; }
    }
}