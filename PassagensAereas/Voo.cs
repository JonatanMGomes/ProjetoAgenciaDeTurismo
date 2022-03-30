namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class Voo
    {
        public int NumeroDoVoo { get; private set;}
        public DateTime HorarioDoVoo { get; private set;}
        public string DestinoDoVoo { get; private set;}
        public string OrigemDoVoo { get; private set;}
        public Voo(int numeroDoVoo, DateTime horarioDoVoo, string destinoDoVoo, string origemDoVoo){
            NumeroDoVoo = numeroDoVoo;
            HorarioDoVoo = horarioDoVoo;
            DestinoDoVoo = destinoDoVoo;
            OrigemDoVoo = origemDoVoo;
        }
    }
}