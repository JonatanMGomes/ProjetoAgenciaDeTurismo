namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class Escala
    {
        public DateTime Duracao { get; private set;}
        public string LocalDaEscala { get; private set;}
        public DateTime HorarioDaChegada { get; private set;}
        public Escala(DateTime duracao, string localDaEscala, DateTime horarioDaChegada){
            Duracao = duracao;
            LocalDaEscala = localDaEscala;
            HorarioDaChegada = horarioDaChegada;
        }
    }
}