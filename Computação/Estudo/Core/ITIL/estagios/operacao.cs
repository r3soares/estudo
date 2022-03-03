using Estudo.Core.ITIL;

namespace ITIL
{
    public class Operacao : Estagio
    {
        public Dictionary<string, string> DefinicoesImportantes { get; init; }
        public Funcao[] Funcoes { get; init; }

        public Operacao()
        {
            DefinicoesImportantes = new Dictionary<string, string>()
            {
                {"Requisição de Serviço","Pedido de informação para uma mudança ou para acessar um serviço de TI. Geralmente atendida pela Central de Serviços"},
                {"Evento","Status report criado por um serviço, IC ou ferramenta de monitoramento. Geralmente requer que incidentes sejam registrados"},
                {"Alerta","Aviso ou advertência sobre uma meta, mudança ou falha que ocorreu"},
                {"Incidente","Interrupção inesperada ou redução na qualidade de um serviço"},
                {"Solução de Contorno (workaround)","Resolve uma dificuldade ou questão de forma temporária, paliativa"},
                {"Erro conhecido (know error)","Problema que tem uma causa raiz documentada e uma solução de contorno identificada"},
                {"Base de Erros Conhecidos","Registro centralizado de erros conhecidos. Faz parte do SKMS / SGCS"},
                {"Impacto","Considera quantas pessoas, clientes ou quanto do negócio será afetado"},
                {"Urgência","Determina a velocidade em que o incidente precisa ser resolvido"},
                {"Prioridade","Determina a ordem de execução baseado no Impacto x Urgência"},
            };

            Funcoes = new Funcao[]
            {
                new CentralServico()
                {
                    Nome = "Central de Serviço",
                    Objetivo = "Responsável por receber e internalizar uma série de eventos de diferentes naturezas. Ponto único de contato para os usuários de TI",
                },
            };
        }
    }
}