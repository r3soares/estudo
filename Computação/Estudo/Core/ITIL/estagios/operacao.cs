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
                new GerenciamentoTecnico()
                {
                    Nome = "Gerenciamento Técnico",
                    Objetivo = "Estrutura que contém profissionais capazes de ajudar no planejamento, na implementação e na manutenção da infraestrutura dos serviços de TI",
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
                    Objetivo = "Restaurar o serviço o mais rápido possível, além de minimizar os impactos adversos nas operações de negócio",
                },
                new GerenciamentoEventos()
                {
                    Nome = "Gerenciamento de Eventos",
                    Objetivo = "Busca-se gerar e detectar notificações de eventos.",
                },
                new GerenciamentoRequisicoes()
                {
                    Nome = "Gerenciamento (ou Cumprimento) de Requisições",
                    Objetivo = "Disponibilizar um canal para que usuários e clientes possam solicitar e utilizar serviços padronizados que tenham um processo pré definido aprovado e qualificado",
                },
                new GerenciamentoAcesso()
                {
                    Nome = "Gerenciamento de Acesso",
                    Objetivo = "Prover privilégios para que os usuários acessem um ou mais serviços, além de prevenir acessos não autorizados. Busca preservar o CID",
                },
                new GerenciamentoProblemas()
                {
                    Nome = "Gerenciamento de Problemas",
                    Objetivo = "Gerenciar o ciclo de vida dos problemas, minimizar o impacto para o negócio e encontrar as causas dos incidentes e previnir a sua ocorrência",
                }
            };
        }
    }
}