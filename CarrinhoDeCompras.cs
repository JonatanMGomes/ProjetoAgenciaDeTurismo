using ProjetoAgenciaDeTurismo.PacoteDeViagens;
using ProjetoAgenciaDeTurismo.PassagensAereas;

namespace ProjetoAgenciaDeTurismo
{
    public class CarrinhoDeCompras
    {
        public List<PacoteDeViagem> PacotesDeViagem { get; set; }
        public List<PassagemAerea> PassagensAereas { get; set; }
        public string FormaDePagamento { get; set; }
        public Cliente Cliente { get; set; }
        public double ValorTotalCarrinho { get; set; }
        public CarrinhoDeCompras(){
            PacotesDeViagem = new List<PacoteDeViagem>();
            PassagensAereas = new List<PassagemAerea>();
        }
        public void AdicionarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
        public void EscolherFormaDePagamento()
        {
            Console.WriteLine("Qual a forma de pagamento desejada? 1-Dinheiro | 2-Cartão Crédito | 3-Cartão Débito");
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    FormaDePagamento = "Dinheiro";
                    Console.WriteLine("Pagamento em dinheiro escolhido.");
                    break;
                case "2":
                    FormaDePagamento = "Cartão de Crédito";
                    Console.WriteLine("Pagamento com cartão de crédito escolhido.");
                    break;
                case "3":
                    FormaDePagamento = "Cartão de débito";
                    Console.WriteLine("Pagamento com cartão de débito escolhido.");
                    break;
                default:
                    Console.WriteLine("Opção invádida!");
                    break;
            }
        }
        public void CalcularValorTotalDoCarrinho()
        {
            double valorTotalCarrinho = 0;
            for (int contador = 0; contador < PacotesDeViagem.Count(); contador++)
            {
                valorTotalCarrinho = valorTotalCarrinho + PacotesDeViagem[contador].ValorTotal;
            }
            for (int contador = 0; contador < PassagensAereas.Count(); contador++)
            {
                valorTotalCarrinho = valorTotalCarrinho + PassagensAereas[contador].ValorDaPassagem;
            }
            ValorTotalCarrinho = valorTotalCarrinho;
        }
        public void AplicarDesconto()
        {
            var valorOriginal = ValorTotalCarrinho;
            if (ValorTotalCarrinho > 499.99 && ValorTotalCarrinho <= 5000)
            {
                Console.WriteLine("Parabens! Você recebeu um desconto =D");
                double desconto = ValorTotalCarrinho * 0.05;
                ValorTotalCarrinho = ValorTotalCarrinho - desconto;
                Console.WriteLine($"Valor total original éra de: {valorOriginal}");
                Console.WriteLine($"Total atualizado: {ValorTotalCarrinho}, seu desconto foi de: {desconto}");
            }
            else if (ValorTotalCarrinho > 5000)
            {
                Console.WriteLine("Parabens! Você recebeu um desconto =D");
                double desconto = ValorTotalCarrinho * 0.1;
                ValorTotalCarrinho = ValorTotalCarrinho - (ValorTotalCarrinho * 0.1);
                Console.WriteLine($"Valor total original éra de: {valorOriginal}");
                Console.WriteLine($"Total atualizado: {ValorTotalCarrinho}, seu desconto foi de: {desconto}");
            }
        }
        public void MenuDeComprasCarrinho()
        {
            string escolha;
            do
            {
                Console.WriteLine("Menu do carrinho:");
                Console.WriteLine("Qual produto deseja adicionar ao seu carrinho? 1-Pacote de Viagem | 2- Passagem Aérea | 3-Sair deste menu");
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                    Console.WriteLine("Qual data de ida para o pacote?");
                    var dataIdaPct = DateOnly.Parse(Console.ReadLine());
                    Console.WriteLine("Qual data de volta para o pacote?");
                    var dataVoltaPct = DateOnly.Parse(Console.ReadLine());
                    var pacoteSendoMontado = new PacoteDeViagem(dataIdaPct, dataVoltaPct);
                    pacoteSendoMontado.MenuDeComprasPacote();
                    pacoteSendoMontado.CalcularValorTotalPacote();
                    PacotesDeViagem.Add(pacoteSendoMontado);

                    break;
                    case "2":
                    Console.WriteLine("Qual Cia aérea deseja?");
                    var ciaAerea = Console.ReadLine();
                    Console.WriteLine("Qual poltrona deseja?");
                    var poltrona = Console.ReadLine();
                    Console.WriteLine("Qual data da passagem?");
                    var dataPass = DateOnly.Parse(Console.ReadLine());
                    Console.WriteLine("Qual horario de embarque para a passagem?");
                    var horarioEmbarque = TimeOnly.Parse(Console.ReadLine());
                    var passagemSendoMontada = new PassagemAerea(ciaAerea, poltrona, horarioEmbarque, dataPass, Cliente);
                    passagemSendoMontada.EscolherClassePassagem();
                    passagemSendoMontada.Voo.AdicionarEscala();
                    passagemSendoMontada.CalcularValorPassagem();
                    passagemSendoMontada.GetResumo();
                    PassagensAereas.Add(passagemSendoMontada);
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
        public void FinalizarCompra()
        {
            CalcularValorTotalDoCarrinho();
            AplicarDesconto();
            Console.WriteLine("Resumo final de seu pedido:");
            Console.WriteLine($"Valor total do seu carrinho: {ValorTotalCarrinho}, Forma de pagamento escolhida: {FormaDePagamento}");
            Console.WriteLine($"Foram comprados: {PacotesDeViagem.Count()} Pacotes de Viagens. E {PassagensAereas.Count()} Passagens Aéreas.");
        }

    }
}