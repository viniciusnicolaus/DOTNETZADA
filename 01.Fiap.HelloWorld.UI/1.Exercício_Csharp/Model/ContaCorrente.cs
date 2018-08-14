using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //sealed : classe não pode ser herdada
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }

        
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && valor > Saldo)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
}
