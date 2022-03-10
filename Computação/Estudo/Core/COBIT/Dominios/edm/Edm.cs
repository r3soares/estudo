namespace COBIT
{
    //Dominio para Governança Empresaria de TI
    public class Edm : Dominio
    {
        public Edm()
        {
            Nome = "Avaliar, Dirigir e Monitorar";
            Sigla = "EDM";
            Objetivo = "";
            Processos = new Processo[5]
            {
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
            };
        }
    }
}