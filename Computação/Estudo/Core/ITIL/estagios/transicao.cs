namespace Computacao.ITIL
{
    public class Transicao : Estagio
    {
        public Transicao()
        {
            Processos = new Processo[]
            {
                new GerenciamentoConfiguracao()
                {
                    Nome = "Gerenciamento da Configura��o e Ativos de Servi�os",
                    Objetivo = "Busca-se identificar, controlar e prestar contas dos ativos de servi�os e itens de configura��o protegendo e garantindo sua integridade",
                },
                new GerenciamentoConhecimento()
                {
                    Nome = "Gerenciamento do Conhecimento",
                    Objetivo = "Busca possibilitar o provedor de servi�o a ser mais eficiente e a melhorar a qualidade do servi�o, aumentando a satisfa��o e reduzindo o custo do servi�o",
                },
                new GerenciamentoLiberacao()
                {
                    Nome = "Gerenciamento da Libera��o e Implanta��o",
                    Objetivo = "Suportar, construir e colocar em produ��o todos os aspectos de servi�os e estabelecer o uso efetivo de servi�os",
                },
                new GerenciamentoMudanca()
                {
                    Nome = "Gerenciamento de Mudan�as",
                    Objetivo = "Assegura que mudan�as s�o feitas de forma controlada, e s�o avaliadas, priorizadas, planejadas, testadas, implantadas e documentadas",
                },
                new GerenciamentoValidacao()
                {
                    Nome = "Valida��o e Testes de Servi�o",
                    Objetivo = "Prover evid�ncia f�sica que o servi�o novo ou alterado suporta os requisitos de neg�cio, incluindo o SLA estabelecido",
                },
                new Avaliacao()
                {
                    Nome = "Avalia��o de Mudan�as",
                    Objetivo = "Respons�vel pela avalia��o formal de um servi�o novo ou alterado para garantir que os riscos tenham sido gerenciados e se a mudan�a deve ser autorizada.",
                },
                new PlanejamentoSuporte()
                {
                    Nome = "Planejamento e Suporte da Transi��o",
                    Objetivo = "Planejar e coordenar recursos para garantir que os requisitos codificados no desenho do servi�o sejam realmente atendidos durante a opera��o do servi�o",
                },
            };
        }
    }
}