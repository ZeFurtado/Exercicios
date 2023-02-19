using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe
{
    internal class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNascimento;


        public string ResumoPessoa()
        {
            string ResumoPessoa = $"Nome: {Nome}";
            ResumoPessoa += $"\nSexo: {Sexo}";
            ResumoPessoa += $"\nData de Nascimento: {DataNascimento}";

            return ResumoPessoa;
        }
    }
}
