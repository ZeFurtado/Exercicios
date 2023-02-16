namespace _01_Classe 
{
    class Pessoa
    {
        string Nome;
        string Sexo;
        DateTime DataNascimento;


        public string ResumoPessoa() 
        {
            string ResumoPessoa = $"Nome: {Nome}";

            return ResumoPessoa;
        }
    }
}
