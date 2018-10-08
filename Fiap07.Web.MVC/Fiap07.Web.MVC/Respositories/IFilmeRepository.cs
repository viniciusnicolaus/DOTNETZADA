using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap07.Web.MVC.Respositories
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme filme);
        void Excluir(int codigo);
        void Atualizar(Filme filme);
        Filme buscarporCodigo(int codigo);
        IList<Filme> Listar();
        IList<Filme> buscarPor(Expression<Func<Filme, bool>> filtro);

    }
}
