namespace Computacao.ITIL
{
    public class GerenciamentoSeguranca : Processo
    {
        public LinkedList<KeyValuePair<string,string>> Ciclo { get; init; }


        public GerenciamentoSeguranca()
        {
            Ciclo = new LinkedList<KeyValuePair<string, string>>();
            Ciclo.AddLast(new KeyValuePair<string, string>("Controlar", "Trata da organiza��o e gerenciamento do processo"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Planejar", "Definir o aspecto da seguran�a do ANS, detalhando em ANOs posteriormente"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Implantar", "Implantar todas as medidas especificadas nos planejamentos"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Avaliar", "Avaliar o desempenho das medidas planejadas a atende aos requisitos de clientes e terceiros"));
            Ciclo.AddLast(new KeyValuePair<string, string>("Manuten��o", "Mant�m a parte do ANS que trata da seguran�a e mant�m os planos detalhados de seguran�a"));
        }
    }
}