namespace MPS_BR
{
    public class MR_MPS_SW : Modelo
    {
        public Nivel[] Niveis { get; init; }

        public MR_MPS_SW()
        {
            var atributosDeProcesso = new AtributoDeProcesso[]
            {
                new AtributoDeProcesso()
                {
                    Ordem = "AP1.1",
                    Nome = "Processo é Executado"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP2.1",
                    Nome = "Execução do Processo é Gerenciada"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP2.2",
                    Nome = "Produtos de trabalho do processo são gerenciados"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP3.1",
                    Nome = "Processo é Definido"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP3.2",
                    Nome = "Processo está Implementado"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP4.1",
                    Nome = "Processo é objeto de análise quantitativa"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP4.2",
                    Nome = "Processo é controlado Quantitativamente"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP5.1",
                    Nome = "Processo é objeto de melhorias incrementais e inovações"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP5.2",
                    Nome = "Processo é Otimizado continuamente"
                },
            };

            var processos = new Processo[]
            {
                new Processo()
                {
                    Sigla = "GPR",
                    Nome = "Gerência de Projetos",
                },
                new Processo()
                {
                    Sigla = "GRE",
                    Nome = "Gerência de Requisitos",
                },
                new Processo()
                {
                    Sigla = "AQU",
                    Nome = "Aquisição",
                    Opcional = true,
                },
                new Processo()
                {
                    Sigla = "GCO",
                    Nome = "Gerência de Configuração",
                },
                new Processo()
                {
                    Sigla = "GPP",
                    Nome = "Gerência de Portfólio de Projetos",
                    Opcional = true,
                },
                new Processo()
                {
                    Sigla = "GQA",
                    Nome = "Garantia da Qualidade",
                },
                new Processo()
                {
                    Sigla = "MED",
                    Nome = "Medição",
                },
                new Processo()
                {
                    Sigla = "AMP",
                    Nome = "Avaliação e Melhoria do Processo Organizacional",
                },
                new Processo()
                {
                    Sigla = "DFP",
                    Nome = "Definição do Processo Organizacional",
                },
                new Processo()
                {
                    Sigla = "GRH",
                    Nome = "Gerência de Recursos Humanos",
                },
                new Processo()
                {
                    Sigla = "GRU",
                    Nome = "Gerência de Reutilização",
                },
                new Processo()
                {
                    Sigla = "GPR",
                    Nome = "Gerência de Projetos - Evolução",
                },
                new Processo()
                {
                    Sigla = "DRE",
                    Nome = "Desenvolvimento de Requisitos",
                },
                new Processo()
                {
                    Sigla = "ITP",
                    Nome = "Integração de Produto",
                },
                new Processo()
                {
                    Sigla = "CPC",
                    Nome = "Projeto e Construção de Produto",
                },
                new Processo()
                {
                    Sigla = "VAL",
                    Nome = "Validação",
                },
                new Processo()
                {
                    Sigla = "VER",
                    Nome = "Verificação",
                },
                new Processo()
                {
                    Sigla = "GDE",
                    Nome = "Gerência de Decisão",
                },
                new Processo()
                {
                    Sigla = "DRU",
                    Nome = "Desenvolvimento para Reutilização",
                    Opcional = true,
                },
                new Processo()
                {
                    Sigla = "GRI",
                    Nome = "Gerência de Riscos",
                },
                new Processo()
                {
                    Sigla = "GPR",
                    Nome = "Gerência de Projetos",
                },
            };

            Niveis = new Nivel[]
            {
                new Nivel()
                {
                    Categoria = "G",
                    GestaoDoProcesso = "Parcialmente Gerenciado",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP.Executado11],
                        atributosDeProcesso[(int)AP.Gerenciado21]
                    },
                    Processos = new Processo[]
                    {
                        processos[(int)ProcessoEnum.GPR1],
                        processos[(int)ProcessoEnum.GRE],
                    }
                },
                new Nivel()
                {
                    Categoria = "F",
                    GestaoDoProcesso = "Gerenciado",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                    }
                },
                new Nivel()
                {
                    Categoria = "E",
                    GestaoDoProcesso = "Parcialmente Definido",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                    }
                },
                new Nivel()
                {
                    Categoria = "D",
                    GestaoDoProcesso = "Largamente Definido",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                    }
                },
                new Nivel()
                {
                    Categoria = "C",
                    GestaoDoProcesso = "Definido",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                    }
                },
                new Nivel()
                {
                    Categoria = "B",
                    GestaoDoProcesso = "Gerenciado Quantitativamente",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                        atributosDeProcesso[(int)AP. Quantitativo41],
                        atributosDeProcesso[(int)AP. Quantitativo42],
                    }
                },
                new Nivel()
                {
                    Categoria = "A",
                    GestaoDoProcesso = "Em Otimização",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                        atributosDeProcesso[(int)AP. Quantitativo41],
                        atributosDeProcesso[(int)AP. Quantitativo41],
                        atributosDeProcesso[(int)AP. Otimizado51],
                        atributosDeProcesso[(int)AP. Otimizado52],
                    }
                },
            };
        }
    }
}