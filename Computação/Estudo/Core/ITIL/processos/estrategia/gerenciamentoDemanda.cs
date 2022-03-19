namespace Computacao.ITIL
{
    /*
        Os objetivos do Gerenciamento da Demanda são a interpretação da demanda e o fornecimento de 
        capacidade para atendimento da demanda. Além disso é necessário exercer influência na demanda 
        do cliente. Seu foco principal está na análise, rastreamento, monitoramento e documentação dos 
        padrões de atividade do negócio. Desta maneira busca-se saber quais são as demandas atuais e 
        prever quais serão as demandas futuras.
        Destaca-se, no Gerenciamento da Demanda, o PAN (Padrões de Atividade de Negócio). Ativos do 
        cliente, tais como pessoas, processos e aplicativos, podem gerar um PAN. O Gerenciamento de 
        Demanda, nesse contexto, utiliza os PAN para analisar, rastrear e monitorar as demandas atuais, e 
        prever as futuras demandas por serviços. Os padrões de atividade vão dizer como o cliente usa os 
        serviços e quais são os períodos de pico. Após ser documentado pelo Gerenciamento da Demanda, 
        o PAN é administrado pela Operação de Serviço.
    */
    public class GerenciamentoDemanda : Processo
    {
        public string PAN { get; init; } = "Padrão de Atividades de Negócio";
        public string Papel { get; init; } = "Gerente de Demanda";
    }
}