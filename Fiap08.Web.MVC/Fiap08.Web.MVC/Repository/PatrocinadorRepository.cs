using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;

namespace Fiap08.Web.MVC.Repository
{
    public class PatrocinadorRepository : IPatrocinadorRepository
    {
        public void Atualizar(Patrocinador patrocinador)
        {
            throw new NotImplementedException();
        }

        public Projeto Buscar(int codigo)
        {
            throw new NotImplementedException();
        }

        public IList<Patrocinador> BuscarPor(Expression<Func<Patrocinador>> filtro)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Patrocinador patrocinador)
        {
            throw new NotImplementedException();
        }

        public IList<Patrocinador> Listar()
        {
            throw new NotImplementedException();
        }

        public void Remmover(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}