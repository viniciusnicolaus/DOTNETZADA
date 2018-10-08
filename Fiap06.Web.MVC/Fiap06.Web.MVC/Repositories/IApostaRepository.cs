using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap06.Web.MVC.Repositories
{
    public interface IApostaRepository
    {
        IList<Aposta> Listar();
        void Cadastrar(Aposta aposta);
        void Atualizar(Aposta aposta);
        Aposta BuscarPorCodigo(int codigo);
        void Excluir(int codigo);
        IList<Aposta> BuscarPor(Expression<Func<Aposta, bool>> filtro);
    }
}
