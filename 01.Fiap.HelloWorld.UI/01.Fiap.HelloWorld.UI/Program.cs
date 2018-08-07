using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Aluno
            Aluno aluno = new Aluno("Deile", 78037);
            aluno.Nome = "Dale"; // set
            Console.WriteLine(aluno.Nome); //get

            //Instanciar o professor
            Professor prof = new Professor("Doly")
            {
                Nome = "Deile",
                Idade = 18
            };
        }
    }
}
