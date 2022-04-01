namespace ProjetoAgenciaDeTurismo.PacoteDeViagens
{
    public class PacoteDeViagem
    {
        public DateOnly DataIda { get; private set; }
        public DateOnly DataVolta { get; private set; }
        public double ValorTotal { get; private set; }
        public List<ServicoOpcional> Opcionais { get; private set; }
        public List<PasseioLocal> Passeios { get; private set; }
        public PacoteDeViagem(DateOnly dataIda, DateOnly dataVolta)
        {
            DataIda = dataIda;
            DataVolta = dataVolta;
            Opcionais = new List<ServicoOpcional>();
            Passeios = new List<PasseioLocal>();
        }
        public void AdicionarServicoOpcional()
        {
            Console.WriteLine("Gostaria de adicionar qual serviço ao seu pacote?");
            Console.WriteLine("1-Almoço | 2-Jantar | 3-Café da Manhã");
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    Opcionais.Add(new Almoco(25));
                    Console.WriteLine("Almoço adicionado ao seu pacote.");
                    break;
                case "2":
                    Opcionais.Add(new Jantar(30));
                    Console.WriteLine("Jantar adicionado ao seu pacote.");
                    break;
                case "3":
                    Opcionais.Add(new CafeDaManha(10));
                    Console.WriteLine("Café da Manhã adicionado ao seu pacote.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        public void AdicionarPasseioLocal()
        {
            Console.WriteLine("Qual o passeio local que você quer?");
            string localDoPasseio = Console.ReadLine();
            Console.WriteLine("Em qual horário?");
            var horario = TimeOnly.Parse(Console.ReadLine());
            Passeios.Add(new PasseioLocal(500, localDoPasseio, horario));
            Console.WriteLine("Passeio adicionado com sucesso!");
        }
        public void MenuDeComprasPacote()
        {
            string escolha;
            do
            {
                Console.WriteLine("Menu do Pacote:");
                Console.WriteLine("Qual produto deseja adicionar ao seu Pacote? 1-Serviços Opcionais | 2-Passeio LOcal | 3-Sair deste Menu");
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                    AdicionarServicoOpcional();
                    break;
                    case "2":
                    AdicionarPasseioLocal();
                    break;
                    case "3":
                    Console.WriteLine("Voltando ao menu anterior.");
                    break;
                    default:
                    Console.WriteLine("Opção inválida!");
                    break;
                }
            } while(escolha != "3");


        }
        public void CalcularValorTotalPacote()
        {
            double valorComplementar = 0;
            for (int contador = 0; contador < Opcionais.Count(); contador++)
            {
                valorComplementar = valorComplementar + Opcionais[contador].Valor;
            }
            for (int contador = 0; contador < Passeios.Count(); contador++)
            {
                valorComplementar = valorComplementar + Passeios[contador].Valor;
            }
            ValorTotal = valorComplementar;
        }
    }
}