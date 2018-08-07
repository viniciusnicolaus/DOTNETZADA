using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Aluno : Pessoa
    {
        //Propriedades
        public int Rm { get; set; }
        public decimal Mensalidade { get; set; }

        //Construtor
        public Aluno(string nome, int rm) : base(nome)
        {
            Rm = rm;

        }

        public override void FazerProva()
        {
            Console.WriteLine("Fazendo prova de Enterprise");
        }

        public override void Estudar()
        {
            Console.WriteLine("Aluno estudando muito a matéria nova");
        }
    }
}
