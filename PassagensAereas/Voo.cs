namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class Voo
    {
        public int NumeroDoVoo { get; private set;}
        public TimeOnly HorarioDoVoo { get; private set;}
        public string DestinoDoVoo { get; private set;}
        public string OrigemDoVoo { get; private set;}
        public List<Escala> EscalasDoVoo { get; private set; }
        public Voo(int numeroDoVoo, TimeOnly horarioDoVoo, string destinoDoVoo, string origemDoVoo){
            NumeroDoVoo = numeroDoVoo;
            HorarioDoVoo = horarioDoVoo;
            DestinoDoVoo = destinoDoVoo;
            OrigemDoVoo = origemDoVoo;
            EscalasDoVoo = new List<Escala>();
        }
        public void AdicionarEscala(){
            string local1 = "São Paulo";
            EscalasDoVoo.Add(new Escala(TimeOnly.Parse("01:20"), local1, HorarioDoVoo.AddMinutes(80)));
            string local2 = "Fortaleza";
            EscalasDoVoo.Add(new Escala(TimeOnly.Parse("03:40"),local2, HorarioDoVoo.AddMinutes(220)));
        }
    }
}