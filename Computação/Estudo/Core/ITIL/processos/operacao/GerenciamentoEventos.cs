namespace ITIL
{
    public class GerenciamentoEventos : Processo
    {
        public Dictionary<string,string> Ferramentas { get; init; }

        public GerenciamentoEventos()
        {
            Ferramentas = new Dictionary<string, string>()
            {
                {"Ativas","Avaliam itens chave de configuração para determinar sua situação e disponibilidade"},
                {"Passivas","Detectam e correlacionam alertas operacionais ou comunicações geradas por itens de configuração"},
            };
        }
    }
}