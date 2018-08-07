using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPopanca : Conta, IContaInvestimento
    {

        public decimal Taxa { get; set; }

        private readonly decimal _rendimento;

        public decimal Rendimento
        {
            get { return _rendimento; }
        }

        public override decimal Depositar()
        {
            return Saldo += 10;
        }

        public override decimal Retirar()
        {
            throw new NotImplementedException();
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }
    }
}