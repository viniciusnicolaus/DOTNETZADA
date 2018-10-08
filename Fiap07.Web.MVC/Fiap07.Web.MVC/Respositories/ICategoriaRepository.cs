using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap07.Web.MVC.Respositories
{
    public interface ICategoriaRepository
    {
        void Cadastrar(Categoria categoria);
        void Excluir(int codigo);
        void Atualizar(Categoria categoria);
        Categoria buscarporCodigo(int codigo);
        IList<Categoria> Listar();
        IList<Categoria> buscarPor(Expression<Func<Categoria, bool>> filtro);
    }
}
