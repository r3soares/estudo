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
                {"Requisi��o de Servi�o","Pedido de informa��o para uma mudan�a ou para acessar um servi�o de TI. Geralmente atendida pela Central de Servi�os"},
                {"Evento","Status report criado por um servi�o, IC ou ferramenta de monitoramento. Geralmente requer que incidentes sejam registrados"},
                {"Alerta","Aviso ou advert�ncia sobre uma meta, mudan�a ou falha que ocorreu"},
                {"Incidente","Interrup��o inesperada ou redu��o na qualidade de um servi�o"},
                {"Solu��o de Contorno (workaround)","Resolve uma dificuldade ou quest�o de forma tempor�ria, paliativa"},
                {"Erro conhecido (know error)","Problema que tem uma causa raiz documentada e uma solu��o de contorno identificada"},
                {"Base de Erros Conhecidos","Registro centralizado de erros conhecidos. Faz parte do SKMS / SGCS"},
                {"Impacto","Considera quantas pessoas, clientes ou quanto do neg�cio ser� afetado"},
                {"Urg�ncia","Determina a velocidade em que o incidente precisa ser resolvido"},
                {"Prioridade","Determina a ordem de execu��o baseado no Impacto x Urg�ncia"},
            };

            Funcoes = new Funcao[]
            {
                new CentralServico()
                {
                    Nome = "Central de Servi�o",
                    Objetivo = "Respons�vel por receber e internalizar uma s�rie de eventos de diferentes naturezas. Ponto �nico de contato para os usu�rios de TI",
                },
            };
        }
    }
}