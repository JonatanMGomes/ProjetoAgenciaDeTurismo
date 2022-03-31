namespace ProjetoAgenciaDeTurismo
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public Cliente(string nome, string cpf, DateTime dataDeNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataDeNascimento = dataDeNascimento;
        }
        public string RetornaPrimeiroNome()
        {
            var nomeDividido = Nome.Split(' ');
            string primeiroNome = nomeDividido[0];
            return primeiroNome;
        }
        public void VerificaSeNomeÉValido()
        {
            bool nomeValido;
            do
            {
                if (Nome.Length < 5 || Nome.Length > 55)
                {
                    nomeValido = false;
                    Console.WriteLine("Nome inválido! Por favor informe um nome que tenha entre 5 a 55 caracteres");
                    Nome = Console.ReadLine();
                } else{
                    nomeValido = true;
                }
            } while(nomeValido == false);
        }
    }
}