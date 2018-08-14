using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Exercício_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar as classes
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                DataAbertura = DateTime.Now,
                Numero = 2,
                Saldo = 1000,
                Tipo = TipoConta.Comum
            };

            var cp = new ContaPoupanca(0.006m)//M de money -> cast
            {
                Agencia = 1,
                Numero = 3,
                Saldo = 500,
                DataAbertura = new DateTime(2018, 1, 1),
                Taxa = 10
            };

            try
            {
                cc.Retirar(2000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
         
            Console.WriteLine(cp.Rendimento);
            Console.ReadLine();//Ler o teclado

        }
    }
}
