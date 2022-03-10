namespace COBIT
{
    //Dominio para a Gestão Empresaria de TI
    public class Dss : Dominio
    {
        public Dss()
        {
            Nome = "Entregar, Servir e Suportar";
            Sigla = "DSS";
            Objetivo = "";
            Processos = new Processo[6]
            {
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
            };
        }
    }
}