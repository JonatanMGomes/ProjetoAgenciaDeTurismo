using ProjetoAgenciaDeTurismo.PacoteDeViagens;
using ProjetoAgenciaDeTurismo.PassagensAereas;

namespace ProjetoAgenciaDeTurismo{
    public class Program{
        static void Main(string[] args){
            IniciarSistema();
        }
        public static Cliente CadastrarCliente(){
            Console.WriteLine("Para começar, vamos fazer seu cadastro e liberar seu carrinho de compras.");
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual seu CPF?");
            string cpf = Console.ReadLine();
            Console.WriteLine("Qual sua data de nascimento?");
            DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nome, cpf, dataDeNascimento);
            cliente.VerificaSeNomeÉValido();
            return cliente;
        }

        public static void IniciarSistema(){
            Console.WriteLine("Seja bem vindo a DoDev Turismo!");
            var cliente = CadastrarCliente();
            var carrinhoDeCompras = new CarrinhoDeCompras();
            carrinhoDeCompras.AdicionarCliente(cliente);
            string escolha;
            do{
                Console.WriteLine("O que deseja fazer? 1-Continuar Comprando | 2-Finalizar Compra");
                escolha = Console.ReadLine();
                switch(escolha){
                    case "1":
                    carrinhoDeCompras.MenuDeComprasCarrinho();
                    break;
                    case "2":
                    carrinhoDeCompras.EscolherFormaDePagamento();
                    carrinhoDeCompras.FinalizarCompra();
                    Console.WriteLine("Obrigado por escolher nossa agência! ^-^");
                    break;
                    default:
                    Console.WriteLine("Opção inválida!");
                    break;
                }
            } while(escolha != "2");
        }
    }
}