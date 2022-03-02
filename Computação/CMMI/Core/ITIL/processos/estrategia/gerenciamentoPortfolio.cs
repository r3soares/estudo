namespace ITIL
{
    public class GerenciamentoPortfolio : Processo
    {
        public Dictionary<string,string> Partes { get; init; }
        public Dictionary<string,string[]> PassoPasso { get; init; }

        public string Papel { get; init; } = "Gerente de Portfólio";

        public GerenciamentoPortfolio()
        {
            Partes = new Dictionary<string, string>()
            {
                {"Funil de Serviços","Fila para ser implementado"},
                {"Catálogo se Serviços","Serviços em operação ou prontos para transição"},
                {"Serviços Obsoletos","Foi ou será aposentado e retirado do ambiente de produção"},

            };
            PassoPasso = new Dictionary<string, string[]>
            {
                {"Define",new string[] 
                    {
                        "Inventário de Serviços",
                        "Casos de Negócio"
                    }
                },
                {"Analisa",new string[] 
                    {
                        "Proposição de Valor",
                        "Priorização e Balanceamento"
                    }
                },
                {"Aprova",new string[] 
                    {
                        "Aprovação de Portfólio",
                        "Autorização de Serviços e Recursos"
                    }
                },
                {"Contrata",new string[] 
                    {
                        "Comunicação de Decisões",
                        "Alocação de Recursos",
                        "Contratação de Serviços",
                    }
                },
            };
        }
    }
}