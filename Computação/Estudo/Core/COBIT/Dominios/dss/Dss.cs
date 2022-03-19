namespace Computacao.COBIT
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
                new Processo(){
                    Nome = "Gerenciar as Operações",
                },
                new Processo(){
                    Nome = "Gerenciar Requisições de Serviço e Incidentes",
                },
                new Processo(){
                    Nome = "Gerenciar Problemas",
                },
                new Processo(){
                    Nome = "Gerenciar a Continuidade",
                },
                new Processo(){
                    Nome = "Gerenciar os Serviços de Segurança",
                },
                new Processo(){
                    Nome = "Gerenciar os Controles de Processos de Negócio",
                },
            };
        }
    }
}