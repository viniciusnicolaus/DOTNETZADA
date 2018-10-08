using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;

namespace Fiap07.Web.MVC.Respositories
{
    public class FilmeRepository : IFilmeRepository
    { 
    private FiaplixContext _context;

    public FilmeRepository(FiaplixContext context)
    {
        _context = context;
    }
    
    public void Atualizar(Filme filme)
    {
        _context.Entry(filme).State = EntityState.Modified;
    }

    public IList<Filme> buscarPor(Expression<Func<Filme, bool>> filtro)
    {
        return _context.Filmes.Where(filtro).ToList();
    }

    public Filme buscarporCodigo(int codigo)
    {
        return _context.Filmes.Find(codigo);
    }

    public void Cadastrar(Filme filme)
    {
         _context.Filmes.Add(filme);
    }

    public void Excluir(int codigo)
    {
        var filme = _context.Filmes.Find(codigo);
        _context.Filmes.Remove(filme);
    }

    public IList<Filme> Listar()
    {
        return _context.Filmes.ToList();
    }
}
}