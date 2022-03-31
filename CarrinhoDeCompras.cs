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
        public void AdicionarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
        public void AdicionarPacoteDeViagem(PacoteDeViagem pacoteEscolhido)
        {
            PacotesDeViagem.Add(pacoteEscolhido);
        }
        public void AdicionarPassagemAerea(PassagemAerea passagemEscolhida)
        {
            PassagensAereas.Add(passagemEscolhida);
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
        }
        public void AplicarDesconto()
        {
            if (ValorTotalCarrinho > 499.99 && ValorTotalCarrinho <= 5000)
            {
                double desconto = ValorTotalCarrinho*0.05;
                ValorTotalCarrinho = ValorTotalCarrinho - desconto;
                Console.WriteLine($"Total atualizado: {ValorTotalCarrinho}, seu desconto foi de: {desconto}");
            }
            else if (ValorTotalCarrinho > 5000)
            {
                double desconto = ValorTotalCarrinho*0.1;
                ValorTotalCarrinho = ValorTotalCarrinho-(ValorTotalCarrinho*0.1);
                Console.WriteLine($"Total atualizado: {ValorTotalCarrinho}, seu desconto foi de: {desconto}");
            }
        }

    }
}