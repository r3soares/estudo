using Computacao.ITIL;

namespace Computacao.ITIL
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
                new GerenciamentoTecnico()
                {
                    Nome = "Gerenciamento T�cnico",
                    Objetivo = "Estrutura que cont�m profissionais capazes de ajudar no planejamento, na implementa��o e na manuten��o da infraestrutura dos servi�os de TI",
                },
                new GerenciamentoAplicativos()
                {
                    Nome = "Gerenciamento de Aplicativos",
                    Objetivo = "Gerencia aplicativos ao longo do seu ciclo de vida",
                },
            };

            Processos = new Processo[]
            {
                new GerenciamentoIncidentes()
                {
                    Nome = "Gerenciamento de Incidentes",
                    Objetivo = "Restaurar o servi�o o mais r�pido poss�vel, al�m de minimizar os impactos adversos nas opera��es de neg�cio",
                },
                new GerenciamentoEventos()
                {
                    Nome = "Gerenciamento de Eventos",
                    Objetivo = "Busca-se gerar e detectar notifica��es de eventos.",
                },
                new GerenciamentoRequisicoes()
                {
                    Nome = "Gerenciamento (ou Cumprimento) de Requisi��es",
                    Objetivo = "Disponibilizar um canal para que usu�rios e clientes possam solicitar e utilizar servi�os padronizados que tenham um processo pr� definido aprovado e qualificado",
                },
                new GerenciamentoAcesso()
                {
                    Nome = "Gerenciamento de Acesso",
                    Objetivo = "Prover privil�gios para que os usu�rios acessem um ou mais servi�os, al�m de prevenir acessos n�o autorizados. Busca preservar o CID",
                },
                new GerenciamentoProblemas()
                {
                    Nome = "Gerenciamento de Problemas",
                    Objetivo = "Gerenciar o ciclo de vida dos problemas, minimizar o impacto para o neg�cio e encontrar as causas dos incidentes e previnir a sua ocorr�ncia",
                }
            };
        }
    }
}