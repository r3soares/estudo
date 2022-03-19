
using Computacao.BSC;

namespace Computacao.COBIT
{
    //Versão Cobit 5
    public class Cobit
    {
        public string Descricao { get; init; }
        public string[] Caracteristicas { get; init; }
        public string[] Principios { get; init; }

        public string[] ObjetivosGovernanca { get; init; }

        public Dictionary<string,object> CascataObjetivos { get; init; }

        public Dictionary<string,string> Habilitadores { get; init; }

        public Dictionary<string,object> DimensoesHabilitadores { get; init; }
        public Dominio[] Governanca { get; init; }
        public Dominio[] Gestao { get; init; }

        public Capacidade[] Capacidades { get; init; }

        public Escala[] AvaliacaoAtributos { get; init; }
        public BalancedScoreCard MetasGenericas { get; init; }
        public BalancedScoreCard MetasTI { get; init; }

        public Cobit()
        {
            Descricao = "Framework completo e aceito internacionalmente para governança e gerenciamento corporativo de TI";
            Caracteristicas = new string[7]
            {
                "Focado no negócio",
                "Orientado a processos",
                "Utiliza métricas e modelos orientados a processos",
                "Não é uma metodologia",
                "Trata a governança de forma holística",
                "Pode ser usado por organizações de todos os portes",
                "Genérico para representar todos os processos comuns de TI",
            };

            Principios = new string[5]
            {
                "Satisfazer as necessidades das partes interessadas",
                "Cobrir a organização de ponta a ponta",
                "Aplicar o um framework integrado e único",
                "Possibilitar uma visão holística",
                "Separar Governança de Gestão",
            };

            ObjetivosGovernanca = new string[3]
            {
                "Realização de Benefícios",
                "Risco em níveis aceitáveis",
                "Otmização de Recursos",
            };

            CascataObjetivos = new Dictionary<string, object>(4)
            {
                {"Necessidade das partes interessadas",ObjetivosGovernanca},
                {"Metas ou objetivos corporativos",""},
                {"Metas ou objetivos de TI",""},
                {"Metas ou objetivos dos habilitadores",""},
            };

            Habilitadores = new Dictionary<string, string>(7)
            {
                {"Princípios, Políticas e Modelos","Veículos para a tradução do comportamento desejado em orientações práticas para a gestão diária."},
                {"Processos","Descrevem um conjunto organizado de práticas e atividades para o atingimento de determinados objetivos"},
                {"Estruturas Organizacionais","Principais entidades de tomada de decisão de uma organização"},
                {"Cultura, Ética e comportamento","Das pessoas e da organização"},
                {"Informação","Permeia qualquer organização e inclui todas as informações produzidas e usadas pela organização"},
                {"Serviços, infraestrutura e aplicativos","Incluem a infraestrutura, a tecnologia e os aplicativos"},
                {"Pessoas, habilidades e competências","Estão associadas às pessoas"},
            };

            DimensoesHabilitadores = new Dictionary<string, object>(4)
            {
                {"Partes Interessadas",""},
                {"Objetivos (Metas)",""},
                {"Ciclo de Vida",new string[6] //Fases do ciclo de vida
                {
                    "Planejar",
                    "Projetar",
                    "Construir/Adquirir,Criar/Implementar",
                    "Usar/Operar",
                    "Avaliar/Monitorar",
                    "Atualizar/Descartar",
                }},
                {"Boas Práticas",""},
            };

            Governanca = new Dominio[1]
            {
                new Edm(),
            };

            Gestao = new Dominio[4]
            {
                new Apo(), //Planejar
                new Bai(), //Construir
                new Dss(), //Entregar
                new Mea(), //Monitorar
            };

            Capacidades = new Capacidade[6]
            {
                new Capacidade()
                {
                    Nome = "Processo Inexistente (ou incompleto)",
                    Atributos = new Atributo[]{}
                },
                 new Capacidade()
                {
                    Nome = "Processo Executado",
                    Atributos = new Atributo[1]
                    {
                        new Atributo()
                        {
                            Nivel = "PA 1.1",
                            Nome = "Execução do Processo",
                        },
                    }
                },
                 new Capacidade()
                {
                    Nome = "Processo Gerenciado",
                    Atributos = new Atributo[2]
                    {
                        new Atributo()
                        {
                            Nivel = "PA 2.1",
                            Nome = "Gestão da Execução",
                        },
                        new Atributo()
                        {
                            Nivel = "PA 2.2",
                            Nome = "Gestão dos Produtos de Trabalho",
                        },
                    }
                },
                 new Capacidade()
                {
                    Nome = "Processo Estabelecido",
                    Atributos = new Atributo[2]
                    {
                        new Atributo()
                        {
                            Nivel = "PA 3.1",
                            Nome = "Definição do Processo",
                        },
                        new Atributo()
                        {
                            Nivel = "PA 3.2",
                            Nome = "Implementação do Processo",
                        },
                    }
                },
                 new Capacidade()
                {
                    Nome = "Processo Previsível",
                    Atributos = new Atributo[2]
                    {
                        new Atributo()
                        {
                            Nivel = "PA 4.1",
                            Nome = "Gestão do Processo",
                        },
                        new Atributo()
                        {
                            Nivel = "PA 4.2",
                            Nome = "Controle do Processo",
                        },
                    }
                },
                 new Capacidade()
                {
                    Nome = "Processo Otimizado",
                    Atributos = new Atributo[2]
                    {
                        new Atributo()
                        {
                            Nivel = "PA 5.1",
                            Nome = "Inovação do Processo",
                        },
                        new Atributo()
                        {
                            Nivel = "PA 5.2",
                            Nome = "Otimização do Processo",
                        },
                    }
                },
            };
        
            AvaliacaoAtributos = new Escala[4]
            {
                new Escala()
                {
                    Nome = "N (Não Alcançado)",
                    Descricao = "Há pouca ou nenhuma evidência de realização do Atributo de Processo",
                    RealizacaoMinima = 0,
                    RealizacaoMaxima = 15,
                },
                new Escala()
                {
                    Nome = "P (Parcialmente Alcançado)",
                    Descricao = "Há alguma evidência de realização do Atributo de Processo. Alguns aspectos podem ser imprevisíveis",
                    RealizacaoMinima = 15,
                    RealizacaoMaxima = 50,
                },
                new Escala()
                {
                    Nome = "L (Largamento Alcançado)",
                    Descricao = "Há evidência de uma realização significativa do Atributo de Processo. Algumas fraquezas podem existir",
                    RealizacaoMinima = 50,
                    RealizacaoMaxima = 85,
                },
                new Escala()
                {
                    Nome = "F (Totalmente Alcançado)",
                    Descricao = "Há evidência de uma realização completa do Atributo de Processo. Não deficiências significativas",
                    RealizacaoMinima = 85,
                    RealizacaoMaxima = 100,
                },

            };

            MetasGenericas = new BalancedScoreCard()
            {
                Financeira = new Dimensao()
                {
                    Objetivos = new string[5]
                    {
                        "Valor dos investimentos da organização percebidos pelas partes interessadas",
                        "Portfólio de produtos e serviços competitivos",
                        "Gestão do risco do negócio (salvaguarda de ativos)",
                        "Conformidade com as leis e regulamentos externos",
                        "Transparência Financeira",
                    }
                },
                Cliente = new Dimensao()
                {
                    Objetivos = new string[5]
                    {
                        "Cultura de serviço orientada ao cliente",
                        "Continuidade e disponibilidade do serviço de negócio",
                        "Respostas rápidas para um ambiente de negócios em mudança",
                        "Tomada de decisão estratégica com base na informação",
                        "Otimização dos custos de prestação de serviços",
                    }
                },
                Interna = new Dimensao()
                {
                    Objetivos = new string[5]
                    {
                        "Otimização da funcionalidade do processo de negócio",
                        "Otimização dos custos do processo de negócio",
                        "Gestão de programas de mudanças de negócio",
                        "Produtividade operacional e da equipe",
                        "Conformidade com as políticas internas",
                    }
                },
                TreinamentoCrescimento = new Dimensao()
                {
                    Objetivos = new string[2]
                    {
                        "Pessoas qualificadas e motivadas",
                        "Cultura de inovação de produtos e negócios",
                    }
                }
            };

            MetasTI = new BalancedScoreCard()
            {
                Financeira = new Dimensao()
                {
                    Objetivos = new string[6]
                    {
                        "Alinhamento da estratégia de negócio e de TI",
                        "Conformidade de TI e suporte para conformidade do negócio com as leis e regulamentos externos",
                        "Compromisso da gerência executiva com a tomada de decisões de TI",
                        "Gestão de risco organizacional de TI",
                        "Benefícios obtidos pelo investimento de TI e portfólio de serviços",
                        "Transparência dos custos, benefícios e riscos de TI",
                    }
                },

                Cliente = new Dimensao()
                {
                    Objetivos = new string[2]
                    {
                        "Prestação dos serviços de TI em consonância com os requisitos de negócio",
                        "Uso adequado de aplicativos, informações e soluções tecnológicas",
                    }
                },

                Interna = new Dimensao()
                {
                    Objetivos = new string[7]
                    {
                        "Agilidade de TI",
                        "Segurança da Informação, infraestrutura de processamento e aplicativos",
                        "Otimização de ativos, recursos e capacidades de TI",
                        "Capacitação e apoio aos processos de negócios através da integração de aplicativos e tecnologia",
                        "Entrega de programas fornecendo benefícios, dentro do prazo, orçamento e atendendo requisitos",
                        "Disponibilidade de informaçãoes úteis e confiáveis para tomada de decisão",
                        "Conformidade da TI com as políticas internas",
                    }
                },

                TreinamentoCrescimento = new Dimensao()
                {
                    Objetivos = new string[2]
                    {
                        "Equipes de TI e de negócios motivadas e qualificadas",
                        "Conhecimento, expertise e iniciativas para inovação dos negócios",
                    }
                }
            };
        }
    }
}