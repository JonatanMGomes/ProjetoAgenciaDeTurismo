namespace ProjetoAgenciaDeTurismo.PassagensAereas
{
    public class PassagemAerea
    {
        public string EmpresaAerea { get; private set; }
        public string Classe { get; private set; }
        public string Poltrona { get; private set; }
        public double ValorDaPassagem { get; private set; }
        public DateTime HorarioDeEmbarque { get; private set; }
        public DateTime DataDaPassagem { get; private set; }
        public Voo Voo { get; private set; }
        public bool MalasParaDespachar { get; private set; }
        public Cliente Cliente { get; private set; }

        public PassagemAerea(string empresaArea, string classe, string poltrona, DateTime horarioDeEmbarque, DateTime dataDaPassagem, Cliente cliente)
        {
            EmpresaAerea = empresaArea;
            Classe = classe;
            Poltrona = poltrona;
            ValorDaPassagem = 500;
            HorarioDeEmbarque = horarioDeEmbarque;
            DataDaPassagem = dataDaPassagem;
            MalasParaDespachar = false;
            Cliente = cliente;
        }
        public void AdicionarMalaParaDespachar()
        {
            MalasParaDespachar = true;
        }
        public void RemoverMalaParaDespachar()
        {
            MalasParaDespachar = false;
        }
        public void GetResumo(){
            Console.WriteLine($"Resumo da passagem: Nome: {Cliente.RetornaPrimeiroNome()}, Poltrona: {Poltrona} e Valor: {ValorDaPassagem}");
        }
    }
}