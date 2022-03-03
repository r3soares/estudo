namespace ITIL
{
    public class GerenciamentoLiberacao : Processo
    {
        public Dictionary<string,string> OpcoesLiberacao { get; init; }

        public GerenciamentoLiberacao()
        {
            OpcoesLiberacao = new Dictionary<string, string>()
            {
                {"Big bang ou por fase","big Bang implanta o serviço para todos ao mesmo tempo, enquanto a por fase libera para parte dos usuários"},
                {"Empurrada ou Puxada (Push/Pull)",@"Empurrada, o componente do serviço é implantado a partir da área central para usuários em localizações remotas. 
Puxada, os usuários devem trazer as atualizações pra si, através de downloads ou requisições"},
                {"Automatizada ou Manual","Automodizadas podem ser feitas através de scripts. Manual requer intervenção humana"},
            };
        }
    }
}