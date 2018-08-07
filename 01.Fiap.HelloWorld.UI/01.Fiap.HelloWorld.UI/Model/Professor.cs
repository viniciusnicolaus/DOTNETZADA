using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Professor : Pessoa, ITrabalhador
    {
        //Propriedades (get e set)
        public List<string> Disciplinas { get; set; }

       //Construtor
        public Professor(string nome) : base(nome)
        {

        }

        public override void FazerProva()
        {
            Console.WriteLine("Montando prova de Enterprise para os alunos");
        }

        public void ReceberSalario()
        {
            Console.WriteLine("BOLSA FAMÍLIA CAIU");
        }
    }
}
