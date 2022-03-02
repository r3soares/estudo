namespace ITIL
{
    public class GerenciamentoSeguranca : Processo
    {
        public LinkedList<KeyValuePair<string,string>> Ciclo { get; init; }


        public GerenciamentoSeguranca()
        {
            Ciclo = new LinkedList<KeyValuePair<string, string>>();
            Ciclo.AddLast(new KeyValuePair<string, string>("Controlar", "Trata da organização e gerenciamento do processo"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Planejar", "Definir o aspecto da segurança do ANS, detalhando em ANOs posteriormente"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Implantar", "Implantar todas as medidas especificadas nos planejamentos"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Avaliar", "Avaliar o desempenho das medidas planejadas a atende aos requisitos de clientes e terceiros"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Manutenção", "Mantém a parte do ANS que trata da segurança e mantém os planos detalhados de segurança"));
        }
    }
}