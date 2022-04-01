namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class PassagemAerea
    {
        public string EmpresaAerea { get; private set; }
        public string Classe { get; private set; }
        public string Poltrona { get; private set; }
        public double ValorDaPassagem { get; private set; }
        public TimeOnly HorarioDeEmbarque { get; private set; }
        public DateOnly DataDaPassagem { get; private set; }
        public Voo Voo { get; private set; }
        public bool MalasParaDespachar { get; private set; }
        public Cliente Cliente { get; private set; }

        public PassagemAerea(string empresaArea, string poltrona, TimeOnly horarioDeEmbarque, DateOnly dataDaPassagem, Cliente cliente)
        {
            EmpresaAerea = empresaArea;
            Poltrona = poltrona;
            HorarioDeEmbarque = horarioDeEmbarque;
            DataDaPassagem = dataDaPassagem;
            Voo = new Voo(555, HorarioDeEmbarque.AddMinutes(45) , "Fortaleza", "Porto Alegre");
            MalasParaDespachar = false;
            Cliente = cliente;
        }
        public void AdicionarMalaParaDespachar()
        {
            MalasParaDespachar = true;
        }
        public void RemoverMalaParaDespachar()
        {
            MalasParaDespachar = false;
        }
        public void EscolherClassePassagem()
        {
            bool escolhaFeita = false;
            while (escolhaFeita == false)
            {
                Console.WriteLine("Qual a classe para sua passagem? 1-Econômica | 2-Primeira Classe");
                string escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    Console.WriteLine("Classe escolhida: Econômica");
                    Classe = "Econômica";
                    escolhaFeita = true;
                }
                else if (escolha == "2")
                {
                    Console.WriteLine("Opção inválida!");
                    Classe = "Primeira Classe";
                    escolhaFeita = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        }
        public void CalcularValorPassagem()
        {
            double valorBase = 500;
            valorBase = valorBase + (Voo.EscalasDoVoo.Count() * 100);
            if (Classe == "Primeira Classe")
            {
                valorBase = valorBase * 2;
            }
            if (MalasParaDespachar == true)
            {
                valorBase = valorBase + 150;
            }
            ValorDaPassagem = valorBase;
        }
        public void GetResumo()
        {
            Console.WriteLine($"Resumo da passagem: Nome: {Cliente.RetornaPrimeiroNome()}, Poltrona: {Poltrona}, Classe: {Classe} e Valor: {ValorDaPassagem}");
            Console.WriteLine($"Saindo de {Voo.OrigemDoVoo}, para {Voo.DestinoDoVoo}. Este voo tem {Voo.EscalasDoVoo.Count()} escalas.");
        }
    }
}