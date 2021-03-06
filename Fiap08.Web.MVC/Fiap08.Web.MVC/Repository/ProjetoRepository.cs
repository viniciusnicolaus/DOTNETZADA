﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Persistencia;
using Fiap08.Web.MVC.Units;

namespace Fiap08.Web.MVC.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {

        public FiapContext _context;
       
        public ProjetoRepository(FiapContext context)
        {
            _context = context;
        }

        public Projeto Buscar(int codigo)
        {
            return _context.Projetos.Find(codigo);
        }

        public IList<Projeto> BuscarPor(Expression<Func<Projeto, bool>> filtro)
        {
            return _context.Projetos.Where(filtro).ToList();
        }

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
        }

        public void Editar(Projeto projeto)
        {
            _context.Entry(projeto).State = EntityState.Modified;
        }

        public void Excluir(int codigo)
        {
            
            _context.Projetos.Remove(Buscar(codigo));

        }

        public IList<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
    }
}