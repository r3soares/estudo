namespace Computacao.ITIL
{
    public class GerenciamentoFinanceiro : Processo
    {
        public Dictionary<string,string> Conceitos { get; init; }
        public string Papel { get; init; } = "Gerente Financeiro";

        public GerenciamentoFinanceiro()
        {
            Conceitos = new Dictionary<string, string>()
            {
                {"TCO (Total Cost of Ownership)","Custo total de propriedade de um investimento"},
                {"ROI (Return On Investiment)","Taxa de retorno de um investimento"},
                {"TCU (Total Cost of Utilization)","Custo total de utilização"},
                {"PBP (Payback Period)","Tempo para retorno do investimento"},
                {"NPV (Net Present Value)","Compara investimentos iniciais com retorno futuros"},
                {"IRR (Internal Return Rate)","Taxa de juros para a qual manter o dinheiro investido seria equivalente a utilizá-lo em um novo projeto"},
            };
        }
    }
}