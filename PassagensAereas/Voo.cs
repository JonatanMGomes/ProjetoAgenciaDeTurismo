namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class Voo
    {
        public int NumeroDoVoo { get; private set;}
        public DateTime HorarioDoVoo { get; private set;}
        public string DestinoDoVoo { get; private set;}
        public string OrigemDoVoo { get; private set;}
        public List<Escala> EscalasDoVoo { get; private set; }
        public Voo(int numeroDoVoo, DateTime horarioDoVoo, string destinoDoVoo, string origemDoVoo){
            NumeroDoVoo = numeroDoVoo;
            HorarioDoVoo = horarioDoVoo;
            DestinoDoVoo = destinoDoVoo;
            OrigemDoVoo = origemDoVoo;
        }
        public void AdicionarEscala(){
            Console.WriteLine("Onde será a escala?");
            string local = Console.ReadLine();
            EscalasDoVoo.Add(new Escala(DateTime.Parse("00:45"), local, HorarioDoVoo.AddMinutes(45)));
        }
    }
}