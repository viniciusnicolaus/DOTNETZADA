using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //propriedade
        public decimal Taxa { get; set; }

        public decimal Rendimento
        {
            get { return _rendimento; }
        }
        //field/campos (atributos)
        private readonly decimal _rendimento;
        // Construtor
        public ContaPoupanca(decimal rend)
        {
            _rendimento = rend;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * Rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor + Taxa;
            
        }
    }
}