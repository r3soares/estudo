namespace Computacao.COBIT
{
    public class Mea : Dominio
    {
        //Dominio para a Gestão Empresaria de TI
        public Mea()
        {
            Nome = "Monitorar, Avaliar e Medir";
            Sigla = "MEA";
            Objetivo = "";
            Processos = new Processo[3]
            {
                new Processo(){
                    Nome = "Desempenho e Conformidade",
                },
                new Processo(){
                    Nome = "Sistema de Controle Interno",
                },
                new Processo(){
                    Nome = "Conformidade com Requisitos Externos",
                },
            };
        }
    }
}