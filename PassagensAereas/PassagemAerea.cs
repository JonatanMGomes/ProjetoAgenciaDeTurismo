namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class PassagemAerea
    {
        public string EmpresaAerea { get; private set; }
        public string Classe { get; private set; }
        public string Poltrona { get; private set; }
        public double ValorDaPassagem { get; private set; }
        public DateTime HorarioDeEmbarque { get; private set;} 
        public DateTime DataDaPassagem { get; private set; }
        public Voo Voo { get; private set; }
        public List<Escala> Escalas { get; private set; }
        public PassagemAerea(string empresaArea, string classe, string poltrona, double valorDaPassagem, DateTime horarioDeEmbarque, DateTime dataDaPassagem){
            EmpresaAerea = empresaArea;
            Classe = classe;
            Poltrona = poltrona;
            ValorDaPassagem = valorDaPassagem;
            HorarioDeEmbarque = horarioDeEmbarque;
            DataDaPassagem = dataDaPassagem;
        }
    }
}