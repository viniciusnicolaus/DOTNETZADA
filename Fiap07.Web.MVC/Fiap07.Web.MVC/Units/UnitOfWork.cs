using Fiap07.Web.MVC.Persistencia;
using Fiap07.Web.MVC.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {

        private FiaplixContext _context = new FiaplixContext();

        private IFilmeRepository _FilmeRepository;
        private ICategoriaRepository _CategoriaRepository;

        public IFilmeRepository FilmeRepository
        {
            get
            {
                if (_FilmeRepository == null)
                {
                    _FilmeRepository = new FilmeRepository(_context);
                }
                return _FilmeRepository;
            }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                if (_CategoriaRepository == null)
                {
                    _CategoriaRepository = new CategoriaRepository(_context);
                }
                return _CategoriaRepository;

            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }


        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}