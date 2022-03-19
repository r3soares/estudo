namespace Computacao.COBIT
{
    //Dominio para Governança Empresaria de TI
    public class Edm : Dominio
    {
        public Edm()
        {
            Nome = "Avaliar, Dirigir e Monitorar";
            Sigla = "EDM";
            Objetivo = @"Lista as responsabilidades da alta direção para a avaliação, direcionamento e monitoração
             do uso dos ativos de TI para a criação de valor";
            Processos = new Processo[5]
            {
                new Processo()
                {
                    Nome = "Assegurar o Estabelecimento e Manutenção do Framework de Governança"
                },
                new Processo()
                {
                    Nome = "Assegurar a Entrega de Benefícios",
                },
                new Processo()
                {
                    Nome = "Assegurar a Otimização de Riscos"
                },
                new Processo()
                {
                    Nome = "Assegurar a Otimização de Recursos"
                },
                new Processo()
                {
                    Nome = "Assegurar a Transparência para as partes interessadas",
                },
            };
        }
    }
}