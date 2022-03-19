namespace Computacao.COBIT
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
                new Processo(){
                    Nome = "Gerenciar Programas e Projetos",
                },
                new Processo(){
                    Nome = "Gerenciar a Definição de Requisitos",
                },
                new Processo(){
                    Nome = "Gerenciar a Identificação e Contrução de Soluções",
                },
                new Processo(){
                    Nome = "Gerenciar a Disponibilidade e Capacidade",
                },
                new Processo(){
                    Nome = "Gerenciar a Implementação de Mudança Organizacional",
                },
                new Processo(){
                    Nome = "Gerenciar Mudanças",
                },
                new Processo(){
                    Nome = "Gerenciar Aceite e Transição de Mudança",
                },
                new Processo(){
                    Nome = "Gerenciar o Conhecimento",
                },
                new Processo(){
                    Nome = "Gerenciar os Ativos",
                },
                new Processo(){
                    Nome = "Gerenciar a Configuração",
                },
            };
        }
    }
}