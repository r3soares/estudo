namespace COBIT
{
    public class Mea : Dominio
    {
        //Dominio para a Gestão Empresaria de TI
        public Mea()
        {
            Nome = "monitorar, Avaliar e Medir";
            Sigla = "MEA";
            Objetivo = "";
            Processos = new Processo[3]
            {
                new Processo(),
                new Processo(),
                new Processo(),
            };
        }
    }
}