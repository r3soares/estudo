namespace Computacao.ITIL
{
    public class GerenciamentoLiberacao : Processo
    {
        public Dictionary<string,string> OpcoesLiberacao { get; init; }

        public GerenciamentoLiberacao()
        {
            OpcoesLiberacao = new Dictionary<string, string>()
            {
                {"Big bang ou por fase","big Bang implanta o servi�o para todos ao mesmo tempo, enquanto a por fase libera para parte dos usu�rios"},
                {"Empurrada ou Puxada (Push/Pull)",@"Empurrada, o componente do servi�o � implantado a partir da �rea central para usu�rios em localiza��es remotas. 
Puxada, os usu�rios devem trazer as atualiza��es pra si, atrav�s de downloads ou requisi��es"},
                {"Automatizada ou Manual","Automodizadas podem ser feitas atrav�s de scripts. Manual requer interven��o humana"},
            };
        }
    }
}