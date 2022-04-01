using ProjetoAgenciaDeTurismo.PacoteDeViagens;
using ProjetoAgenciaDeTurismo.PassagensAereas;

namespace ProjetoAgenciaDeTurismo{
    public class Program{
        static void Main(string[] args){

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
        public static void CriarCarrinho(){
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        }
        public static void IniciarSistema(){
            Console.WriteLine("Seja bem vindo a DoDev Turismo!");
            do{
                Console.WriteLine("Qual produto deseja? 1-Pacote de viagem | 2-Passagem Aérea");
            } while();
        }
    }
}