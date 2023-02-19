using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe 
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Nome");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Sexo");
            pessoa.Sexo = Console.ReadLine();

            pessoa.DataNascimento = new DateTime(2000,11,18);


            Console.WriteLine(pessoa.ResumoPessoa());
            Console.ReadKey();

        }
    }
}
