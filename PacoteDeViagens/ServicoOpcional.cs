namespace ProjetoAgenciaDeTurismo.PacoteDeViagens
{
    public class ServicoOpcional
    {
        public double Valor { get; private set; }
        public ServicoOpcional(double valor){
            Valor = valor;
        }
    }
}