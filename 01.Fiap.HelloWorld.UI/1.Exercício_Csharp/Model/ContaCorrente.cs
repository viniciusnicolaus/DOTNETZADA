using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }


        public override decimal Depositar()
        {
            return Saldo += 10;
        }

        public override decimal Retirar()
        {
            if(TipoConta.Comum && saque > Saldo)
            {

            }
        }
    }
}
