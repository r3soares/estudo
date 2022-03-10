namespace COBIT
{
    //Dominio para a Gestão Empresaria de TI
    public class Bai : Dominio
    {
        public Bai()
        {
            Nome = "Construir, Adquirir e Implementar";
            Sigla = "BAI";
            Objetivo = "";
            Processos = new Processo[10]
            {
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
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