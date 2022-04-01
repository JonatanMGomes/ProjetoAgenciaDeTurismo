namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class Escala
    {
        public TimeOnly Duracao { get; private set;}
        public string LocalDaEscala { get; private set;}
        public TimeOnly HorarioDaChegada { get; private set;}
        public Escala(TimeOnly duracao, string localDaEscala, TimeOnly horarioDaChegada){
            Duracao = duracao;
            LocalDaEscala = localDaEscala;
            HorarioDaChegada = horarioDaChegada;
        }
    }
}