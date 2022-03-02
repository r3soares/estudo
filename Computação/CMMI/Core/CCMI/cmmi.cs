using CMMI;

namespace CCMI
{
    public class CMMI
    {
        public string AlicerceDasDimensoes { init; get; } = "Processo";
        public Dimensao[] DimensoesCriticas { init; get; }
        public Representacao[] Abordagens { init; get; }
        public Metas[] AreaDeProcesso { init; get; }

        public CMMI()
        {
            DimensoesCriticas = new Dimensao[]
            {
            new Dimensao() {Nome = "Procedimentos e Métodos"},
            new Dimensao() {Nome = "Pessoas, Treinamento e Motivação"},
            new Dimensao() {Nome = "Ferramentas e Equipamentos"},
            };
            GestaoDoProcesso gProcesso = new GestaoDoProcesso();
            GestaoDoProjeto gProjeto = new GestaoDoProjeto();
            Engenharia engenharia = new Engenharia();
            Suporte suporte = new Suporte();

            Abordagens = new Representacao[]
            {
            new Representacao()
            {
                Nome = "Abordagem Contínua",
                Objetivo = "A empresa pode escolher as áreas de processo que será avaliada em níveis de capacidade (0 a 3)",
                Niveis = new Nivel[]
                {
                    new Nivel()
                    {
                        Ordem = 0,
                        Nome = "Capacidade Incompleto",
                        Descricao = "Processo não é executado ou parcialmente executado",
                    },
                    new Nivel()
                    {
                        Ordem = 1,
                        Nome = "Capacidade Executado",
                        Descricao = "Processo satifaz todas as metas específicas de sua área de processo e realiza o trabalho necessário para gerar seus produtos",
                    },
                    new Nivel()
                    {
                        Ordem = 2,
                        Nome = "Capacidade Gerenciado",
                        Descricao = "Processo é planejado e executado de acordo com políticas organizacionais",
                    },
                    new Nivel()
                    {
                        Ordem = 3,
                        Nome = "Capacidade Definido",
                        Descricao = "Processo é gerenciado e adaptado a partir de um conjunto de processos padronizados da organização",
                    }
                },
            },
            new Representacao()
            {
                Nome = "Abordagem por Estágios",
                Objetivo = "Classificar a empresa através de níveis de maturidade (1 a 5)",
                Niveis = new Nivel[]
                {
                    new Nivel()
                    {
                        Ordem = 1,
                        Nome = "Maturidade Inicial (Ad-hoc)",
                        Descricao = "Geralmente os processos são caóticos. Empresa não fornece um ambiente estável para apoiar os processos",
                        Areas = new AreaDoProcesso[]{},
                    },
                    new Nivel()
                    {
                        Ordem = 2,
                        Nome = "Maturidade Gerenciado",
                        Descricao = "Os projetos da organização têm garantia de que os processos são planejados e executados de acordo com uma política",
                        Areas = new AreaDoProcesso[]
                        {
                            gProjeto.Areas[(int)AreasEnum.PP],
                            gProjeto.Areas[(int)AreasEnum.PMC],
                            gProjeto.Areas[(int)AreasEnum.SAM],
                            gProjeto.Areas[(int)AreasEnum.REQM],

                            suporte.Areas[(int)AreasEnum.CM],
                            suporte.Areas[(int)AreasEnum.PPQA],
                            suporte.Areas[(int)AreasEnum.MA],
                        }
                    },
                    new Nivel()
                    {
                        Ordem = 3,
                        Nome = "Maturidade Definido",
                        Descricao = "Processos bem caracterizados e entendidos, e são descritos em padrões, procedimentos, ferramentas e métodos",
                        Areas = new AreaDoProcesso[]
                        {
                            gProcesso.Areas[(int)AreasEnum.OPF],
                            gProcesso.Areas[(int)AreasEnum.OPD],
                            gProcesso.Areas[(int)AreasEnum.OT],

                            gProjeto.Areas[(int)AreasEnum.IPM],
                            gProjeto.Areas[(int)AreasEnum.RSKM],

                            engenharia.Areas[(int)AreasEnum.RD],
                            engenharia.Areas[(int)AreasEnum.TS],
                            engenharia.Areas[(int)AreasEnum.PI],
                            engenharia.Areas[(int)AreasEnum.VER],
                            engenharia.Areas[(int)AreasEnum.VAL],

                            suporte.Areas[(int)AreasEnum.DAR],
                        }
                    },
                    new Nivel()
                    {
                        Ordem = 4,
                        Nome = "Maturidade Quantitativamente Gerenciado",
                        Descricao = "A organização e os projetos estabelecem objetivos quantitativos para a qualidade e para desempenho de processo",
                        Areas = new AreaDoProcesso[]
                        {
                            gProcesso.Areas[(int)AreasEnum.OPP],

                            gProjeto.Areas[(int)AreasEnum.QPM],
                        }
                    },
                    new Nivel()
                    {
                        Ordem = 5,
                        Nome = "Maturidade em Otimização",
                        Descricao = "A Organização melhora continuamente seus processos com base no entendimento quantitativo das causas comuns",
                        Areas = new AreaDoProcesso[]
                        {
                            gProcesso.Areas[(int)AreasEnum.OPM],

                            suporte.Areas[(int)AreasEnum.CAR],
                        }
                    },
                }
            },
            };

            AreaDeProcesso = new Metas[]
            {
            new Metas()
            {
                Tipo = "Genéricas",
                Praticas = new Praticas(){Tipo = "Genéricas"}
            },
            new Metas()
            {
                Tipo = "Específicas",
                Praticas = new Praticas(){Tipo = "Específicas"}
            },
            };
        }
    }
}
