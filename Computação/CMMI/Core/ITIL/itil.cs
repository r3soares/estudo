namespace ITIL
{
    public class ITIL
    {
        public string Descricao { get; init; } = "Information Technology Infraestruture Library;";
        public string Foco { get; init; } = "Manter e Gerenciar Serviços de TI";
        public Dictionary<string,string> Glossario { get; init; }

        public Estagio[] Estagios { get; init; }

        public ITIL()
        {
            Glossario = new Dictionary<string, string>()
            {
                {"Serviço de TI","Meio para entregar valor ao cliente"},
                {"Gerenciamento de Serviços de TI","É o conjunto de capacidades operacionais realizadas para prover valor sob a forma de serviços"},
                {"Provedor de Serviços de TI","Provê serviços de TI para um Cliente de Negócio. Pode ser interno, externo ou compartilhado"},
                {"Função","Conjunto de pessoas e recursos empregados para realizar um ou mais processos ou atividades"},
                {"Processo","Conjunto de atividades coordenadas com objetivo de produzir uma saída, com criação de valor para um cliente ou parte interessada"},
                {"Ativo","Qualquer recurso ou habilidade de um provedor de serviço que possa contribuir para a entrega de um serviço"},
                {"Dono de Serviço","Responsável pela iniciação, transição, manutenção e suporte de um serviço"},
                {"Dono do Processo","Assegura que o processo seja executado conforme acordado e documentado. Patrocina o processo. Normalmente alguém da gerência sênior"},
                {"Gerente de Processo","É quem gerencia o processo no dia dia"},
                {"Profissional de Processo","Nome dado a alguém que participa da realização de alguma atividade dentro de um processo"},
                {"Valor do Serviço","= Utilidade + Garantia"},
                {"Utilidade","Diz respeito ao que o cliente quer, e caracteriza o que o serviço faz"},
                {"Garantia","Relacionado a como o serviço é feito, à sua qualidade"},
            };

            Estagios = new Estagio[]
            {
                new Estrategia() 
                {
                    Nome = "Estratégia de Serviço",
                    Descricao = "Determina como as políticas e os processos de gerenciamento de serviços podem ser desenhados, desenvolvidos e implementados como ativos estratégicos",
                    Objetivos = new string[]
                    {
                        "Melhorar o impacto estratégico do Gerenciamento de Serviços",
                        "Transformar o Gerenciamento de Serviços em um ativo estratégico",
                        "Fornecer visão clara dos relacionamentos entre os sistemas, processos, funções, serviços, modelos de negócios, estratégias e visão organizacional",
                        "Fornecer gerenciamento com foco estratégico",
                        "Fornecer princípios para o desenvolvimento de políticas, diretrizes e processos do ciclo de vida do processo",
                    }
                },
                new Desenho()
                {
                    Nome = "Desenho (ou Projeto) de Serviço",
                    Descricao = "Fornece orientação para o desenho e desenvolvimento dos produtos e serviços para os processos de gerenciamento de serviços",
                },
                new Transicao()
                {
                    Nome = "Transição de Serviço",
                    Descricao = "Dispõe sobre como efetivar a transição de serviços novos e modificados para operações implementadas",
                },
                new Operacao()
                {
                    Nome = "Operação de Serviço",
                    Descricao = "Descreve a fase do ciclo de vida do gerenciamento de serviço responsável pelas atividades do dia dia",
                },                
                new Melhoria()
                {
                    Nome = "Melhoria Contínua de Serviço",
                    Descricao = "Orientar, por meio de princípios, práticas e métodos de gerenciamento da qualidade, como realizar, sistematicamente, melhorias incrementais em larga escala",
                },
            };
        }
    }
}