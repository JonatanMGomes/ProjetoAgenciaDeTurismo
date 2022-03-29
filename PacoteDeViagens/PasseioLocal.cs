namespace ProjetoAgenciaDeTurismo.PacoteDeViagens
{
    public class PasseioLocal
    {
        public double Valor { get; set; }
        public string Local { get; set; }
        public DateTime Horario { get; set; }
        public PasseioLocal(double valor, string local, DateTime horario){
            Valor = valor;
            Local = local;
            Horario = horario;
        }
    }
}