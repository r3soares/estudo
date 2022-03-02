namespace ITIL
{
    /*
        O objetivo principal deste processo é o desenho de novos serviços ou evolução de serviços existentes 
        para introdução no ambiente de produção. Neste sentido, busca-se conceber processos eficazes e 
        eficientes, definir métricas e métodos de medição e identificar riscos. Além disso, o Desenho de 
        Serviços pode incluir ferramentas de suporte, sistemas e informação e deve envolver o 
        desenvolvimento de novas habilidades.
        Na prova, este estágio do serviço pode aparecer como “Projeto de Serviços”. Aqui é fornecida a 
        orientação para o desenho e desenvolvimento dos produtos e serviços para os processos de 
        gerenciamento de serviços, detalhando aspectos do gerenciamento do catálogo de serviços, do 
        nível de serviço, da capacidade, da disponibilidade, da continuidade, da segurança da informação 
        e dos fornecedores
    */
    public class Desenho : Estagio
    {
        public Dictionary<string,string> Ps { get; init; }
        public Dictionary<string,string> AspectosImportantes { get; init; }
        public SDP ProdutoPrincipal{ get; init; }

        public Desenho()
        {
            ProdutoPrincipal = new SDP()
            {
                Nome = "Service Design Package",
                Descricao = "Contém todos os aspectos dos serviços e as exigências para todas as etapas sucessivas no ciclo de vida",
            };
            Ps = new Dictionary<string, string>()
            {
                {"Pessoas","Determinar os papéis das pessoas no processo"},
                {"Processos","Definir os processos necessários para implantação do serviço"},
                {"Produtos","Quais produtos e quais tecnologias serão utilizadas no serviço"},
                {"Parceiros","Estabelecer parcerias e contatos com os fornecedores"},
            };

            AspectosImportantes = new Dictionary<string, string>()
            {
                {"Identificação dos requisitos","Definição dos requisitos do serviço e Desenho do Serviço"},
                {"Consulta constante ao Portfólio de Serviços","Detalhes do Serviço e seus status"},
                {"Desenho da Arquitetura e Tecnologia","Desenvolvimento e manutenção de políticas, estratégias, documentação, planos e sistema de gerenciamento de serviços"},
                {"Desenho do Proceso","Necessários para transição, operação e melhoria continuada"},
                {"Desenho de Métricas de Medição","Aquilo que não se pode medir, não é gerenciável"},
            };

            Processos = new Processo[]
            {
                new GerenciamentoCatalogo()
                {
                    Nome = "Gerenciamento do Catálogo de Serviços",
                    Objetivo = "Assegurar que o catálogo seja produzido e mantido, contendo informação corretas sobre os serviços",
                },
                new GerenciamentoNivelServico()
                {
                    Nome = "Gerenciamento do Nível de Serviço",
                    Objetivo = "Garantir que todos os serviços estejam em operação e seus desempenhos sejam medidos e que atendam às necessidades do negócio e dos clientes",
                },
                new GerenciamentoCapacidade()
                {
                    Nome = "Gerenciamento da Capacidade",
                    Objetivo = "Gerenciar toda a capacidade e desempenho relacionado a problemas e fazer com que a capacidade corresponda a demanda necessária",
                },
                new GerenciamentoDisponibilidade()
                {
                    Nome = "Gerenciamento da Disponibilidade",
                    Objetivo = "Garantir que o nível de disponibilidade corresponda ou exceda às necessidades atuais e futuras de maneira economicamente viável",
                },
                new GerenciamentoContinuidade()
                {
                    Nome = "Gerenciamento da Continuidade de Serviços",
                    Objetivo = "Manter continuamente a capacidade de recuperação dos serviços de TI para atender as necessidades, aos requisitos e prazos de negócio",
                },
                new GerenciamentoSeguranca()
                {
                    Nome = "Gerenciamento da Segurança da Informação",
                    Objetivo = "Garantir o CID + Não Repúdio",
                },
                new GerenciamentoFornecedor()
                {
                    Nome = "Gerenciamento de Fornecedores",
                    Objetivo = "garantir o retorno adequado dos fornecedores e garantir que eles alcancem metas estabelecidas em seus contatos",
                }
            };
        }
    }
}