namespace Computacao.CMMI
{
    public enum AreasEnum
    {
        OPF = 0,
        OPD = 1,
        OT = 2,
        OPP = 3,
        OPM = 4,
        PP = 0,
        PMC = 1,
        SAM = 2,
        IPM = 3,
        REQM = 4,
        RSKM = 5,
        QPM = 6,
        RD = 0,
        TS = 1,
        PI = 2,
        VER = 3,
        VAL = 4,
        CM = 0,
        PPQA = 1,
        MA = 2,
        DAR = 3,
        CAR = 4,
    }
    public abstract class Categoria
    {
        public AreaDoProcesso[] Areas { get; init; }
    }

    public class GestaoDoProcesso : Categoria
    {
        public GestaoDoProcesso()
        {
            Areas = new AreaDoProcesso[]
            {
            new AreaDoProcesso()
            {
                Sigla = "OPF",
                Nome = "Foco No Processo Organizacional",
                Objetivo = "",
            },
            new AreaDoProcesso()
            {
                Sigla = "OPD",
                Nome = "Definição do Processo Organizacional",
                Objetivo = "",
            },
            new AreaDoProcesso()
            {
                Sigla = "OT",
                Nome = "Treinamento Organizacional",
                Objetivo = "Desenvolver as habilidades e o conhecimento das pessoas",
            },
            new AreaDoProcesso()
            {
                Sigla = "OPP",
                Nome = "Desempenho do Processo Organizacional",
                Objetivo = "Estabelecer e manter uma visão quantitativa do desempenho dos processos padrões",
            },
            new AreaDoProcesso()
            {
                Sigla = "OPM",
                Nome = "Gestão do Desempenho Organizacional",
                Objetivo = "Gerenciar proativamente o desempenho da organização",
            },
            };
        }
    }

    public class GestaoDoProjeto : Categoria
    {
        public GestaoDoProjeto()
        {
            Areas = new AreaDoProcesso[]
            {
            new AreaDoProcesso()
            {
                Sigla = "PP",
                Nome = "Planejamento do Projeto",
                Objetivo = "Estabelecer e manter planos que definam as atividades dos projetos",
            },
            new AreaDoProcesso()
            {
                Sigla = "PMC",
                Nome = "Controle e Monitoração do Projeto",
                Objetivo = "Permitir uma visibilidade adequada do progresso do projeto",
            },
            new AreaDoProcesso()
            {
                Sigla = "SAM",
                Nome = "Gestão do Acordo com o Fornecedor",
                Objetivo = "Gerenciar a aquisição de produtos de fornecedores externos",
            },
            new AreaDoProcesso()
            {
                Sigla = "IPM",
                Nome = "Gestão Integrada de Projeto",
                Objetivo = "Planejar e gerenciar o projeto e o envolvimento dos principais grupos interessados",
            },
            new AreaDoProcesso()
            {
                Sigla = "REQM",
                Nome = "Gestão de Requisitos",
                Objetivo = "Gerenciar os requisitos técnicos e não técnicos absorvidos ou gerados por um projeto",
            },
            new AreaDoProcesso()
            {
                Sigla = "RSKM",
                Nome = "Gestão de Riscos",
                Objetivo = "Identificar possíveis problemas antes que ocorram para mitigar possíveis impactados adversos",
            },
            new AreaDoProcesso()
            {
                Sigla = "QPM",
                Nome = "Gestão Quantitativa do Projeto",
                Objetivo = "Gerenciar quantitativamente o processo definido do projeto",
            },
            };
        }
    }

    public class Engenharia : Categoria
    {
        public Engenharia()
        {
            Areas = new AreaDoProcesso[]
            {
            new AreaDoProcesso()
            {
                Sigla = "RD",
                Nome = "Desenvolvimento de Requisitos",
                Objetivo = "Gerar, analisar, definir e validar requisitos do cliente",
            },
            new AreaDoProcesso()
            {
                Sigla = "TS",
                Nome = "Solução Técnica",
                Objetivo = "Projetar, desenvolver e implementar alternativas de soluções para o atendimento de requisitos preestabelecidos",
            },
            new AreaDoProcesso()
            {
                Sigla = "PI",
                Nome = "Integração do Produto",
                Objetivo = "Montar o produto a partir dos seus componentes e entregá-lo ao cliente",
            },
            new AreaDoProcesso()
            {
                Sigla = "VER",
                Nome = "Verificação",
                Objetivo = "Garantir que um produto satisfaça os respectivos requisitos para os quais foi desenvolvido",
            },
            new AreaDoProcesso()
            {
                Sigla = "VAL",
                Nome = "Validação",
                Objetivo = "Demonstrar que um determinado produto ou componente de produto atinge os resultados esperados",
            },
            };
        }
    }

    public class Suporte : Categoria
    {
        public Suporte()
        {
            Areas = new AreaDoProcesso[]
            {
            new AreaDoProcesso()
            {
                Sigla = "CM",
                Nome = "Gestão da Configuração",
                Objetivo = "Estabelecer e manter a integridade dos produtos de trabalho",
            },
            new AreaDoProcesso()
            {
                Sigla = "PPQA",
                Nome = "Processo de Garantia da Qualidade",
                Objetivo = "Prover aos integrantes das equipes uma visibilidade mais clara do andamento dos processos e dos produtos gerados",
            },
            new AreaDoProcesso()
            {
                Sigla = "MA",
                Nome = "Medição e Análise",
                Objetivo = "Desenvolver e manter uma capacitação de medição para suportar as necessidades de informações gerenciais",
            },
            new AreaDoProcesso()
            {
                Sigla = "DAR",
                Nome = "Análise de Decisões e Resolução",
                Objetivo = "Analisar possíveis decisões utilizando um processo de avaliação formal",
            },
            new AreaDoProcesso()
            {
                Sigla = "CAR",
                Nome = "Análise e Resolução de Causas",
                Objetivo = "Identificar causas de defeitos e outros problemas e tomar ações corretivas para prevenir a sua ocorrência futura",
            },
            };
        }
    }
}