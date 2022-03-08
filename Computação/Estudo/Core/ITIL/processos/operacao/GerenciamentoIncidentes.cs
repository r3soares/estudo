namespace ITIL
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
                "Hierárquica",
            };

            Atividades = new Dictionary<string, string>
            {
                {"Identificação", "Identifica o Incidente" },
                {"Registro", "Registra o incidente com data, hora e informações relevantes" },
                {"Classificação", "Classifica o tipo de incidente. Útil para identificar os incidentes mais recorrentes"},
                {"Priorização", "Código de prioridade baseado no impacto e urgência"},
                {"Diagnóstico", "Executado inicialmente pela Central de Serviços, que tenta descobrir os possiveis sintomas e o que não está funcionando"},
                {"Escalação", "Se não puder ser resolvido pela Central, deve ser escalado dentro do tempo hábil para outro nível de suporte (funcional ou hierárquico)"},
                {"Investigação e Diagnóstico", "Determina a natureza da requisição. Investiga o que ocorreu e faz um diagnóstico."},
                {"Resolução e Recuperação","Identifica uma solução, aplica e testa" },
                {"Fechamento","A Central de Serviços deverá categorizar o motivo do incidente, documentar e fazer o fechamento formal junto ao usuário" },
            };
        }
    }
}