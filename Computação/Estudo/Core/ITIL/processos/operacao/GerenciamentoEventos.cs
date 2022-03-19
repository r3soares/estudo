namespace Computacao.ITIL
{
    public class GerenciamentoEventos : Processo
    {
        public Dictionary<string,string> Ferramentas { get; init; }

        public GerenciamentoEventos()
        {
            Ferramentas = new Dictionary<string, string>()
            {
                {"Ativas","Avaliam itens chave de configura��o para determinar sua situa��o e disponibilidade"},
                {"Passivas","Detectam e correlacionam alertas operacionais ou comunica��es geradas por itens de configura��o"},
            };
        }
    }
}