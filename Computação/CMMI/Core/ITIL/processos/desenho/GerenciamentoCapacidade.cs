namespace ITIL
{
    public class GerenciamentoCapacidade : Processo
    {
        public Dictionary<string,string> PrincipaisProdutos { get; init; }


        public GerenciamentoCapacidade()
        {
            PrincipaisProdutos = new Dictionary<string, string>()
            {
                {"Sistema de Informação do Gerenciamento de Capacidade (SIGC)","Informações são analisadas e armazenadas para fornecer relatórios técnicos e de gerenciamento, incluindo o Plano de Capacidade"},
                {"Plano de Capacidade","Dividido em 3 subprocessos: Gerenciamento da Capacidade de Negócios, Serviços e Componentes"},
            };
        }
    }
}