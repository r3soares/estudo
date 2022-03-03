namespace ITIL
{
    public class Transicao : Estagio
    {
        public Transicao()
        {
            Processos = new Processo[]
            {
                new GerenciamentoConfiguracao()
                {
                    Nome = "Gerenciamento da Configuração e Ativos de Serviços",
                    Objetivo = "Busca-se identificar, controlar e prestar contas dos ativos de serviços e itens de configuração protegendo e garantindo sua integridade",
                },
                new GerenciamentoConhecimento()
                {
                    Nome = "Gerenciamento do Conhecimento",
                    Objetivo = "Busca possibilitar o provedor de serviço a ser mais eficiente e a melhorar a qualidade do serviço, aumentando a satisfação e reduzindo o custo do serviço",
                },
                new GerenciamentoLiberacao()
                {
                    Nome = "Gerenciamento da Liberação e Implantação",
                    Objetivo = "Suportar, construir e colocar em produção todos os aspectos de serviços e estabelecer o uso efetivo de serviços",
                },
                new GerenciamentoMudanca()
                {
                    Nome = "Gerenciamento de Mudanças",
                    Objetivo = "Assegura que mudanças são feitas de forma controlada, e são avaliadas, priorizadas, planejadas, testadas, implantadas e documentadas",
                },
                new GerenciamentoValidacao()
                {
                    Nome = "Validação e Testes de Serviço",
                    Objetivo = "Prover evidência física que o serviço novo ou alterado suporta os requisitos de negócio, incluindo o SLA estabelecido",
                },
                new Avaliacao()
                {
                    Nome = "Avaliação de Mudanças",
                    Objetivo = "Responsável pela avaliação formal de um serviço novo ou alterado para garantir que os riscos tenham sido gerenciados e se a mudança deve ser autorizada.",
                },
                new PlanejamentoSuporte()
                {
                    Nome = "Planejamento e Suporte da Transição",
                    Objetivo = "Planejar e coordenar recursos para garantir que os requisitos codificados no desenho do serviço sejam realmente atendidos durante a operação do serviço",
                },
            };
        }
    }
}