namespace Computacao.ITIL
{
    public class GerenciamentoIncidentes : Processo
    {
        public string[] Escalacao { get; init; }
        Dictionary<string,string> Atividades { get; init; }

        public GerenciamentoIncidentes()
        {
            Escalacao = new string[]
            {
                "Funcional",
                "Hier�rquica",
            };

            Atividades = new Dictionary<string, string>
            {
                {"Identifica��o", "Identifica o Incidente" },
                {"Registro", "Registra o incidente com data, hora e informa��es relevantes" },
                {"Classifica��o", "Classifica o tipo de incidente. �til para identificar os incidentes mais recorrentes"},
                {"Prioriza��o", "C�digo de prioridade baseado no impacto e urg�ncia"},
                {"Diagn�stico", "Executado inicialmente pela Central de Servi�os, que tenta descobrir os possiveis sintomas e o que n�o est� funcionando"},
                {"Escala��o", "Se n�o puder ser resolvido pela Central, deve ser escalado dentro do tempo h�bil para outro n�vel de suporte (funcional ou hier�rquico)"},
                {"Investiga��o e Diagn�stico", "Determina a natureza da requisi��o. Investiga o que ocorreu e faz um diagn�stico."},
                {"Resolu��o e Recupera��o","Identifica uma solu��o, aplica e testa" },
                {"Fechamento","A Central de Servi�os dever� categorizar o motivo do incidente, documentar e fazer o fechamento formal junto ao usu�rio" },
            };
        }
    }
}