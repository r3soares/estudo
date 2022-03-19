namespace Computacao.ITIL
{
    public class GerenciamentoNivelServico : Processo
    {
        public Dictionary<string,string> PrincipaisProdutos { get; init; }


        public GerenciamentoNivelServico()
        {
            PrincipaisProdutos = new Dictionary<string, string>()
            {
                {"Acordos de Nível de Serviço (SLA ou ANS)","Acordo escrito entre o provedor de serviço e cliente externo"},
                {"Acordos de Nível Operacional (OLA ou ANO)","Acordo entre o provedor de serviço e outra parte da organização"},
                {"Planos de Melhoria de Serviço (SIP ou PMS)","Programa global ou plano de ações de melhoria priorizadas"},
                {"Plano de Qualidade de Serviços (SQP ou PQS)","Plano para manutenção ou incremento da qualidade dos serviços"},
                {"ANS baseada em serviço","É específico para todos os clientes que o contratam, mas estes se submetem aos mesmos termos do serviço"},
                {"ANS baseada em cliente","É específico para o cliente ou grupo de cliente."},
                {"ANS multinível ","Cobre todos os assuntos genéricos (Nível Corporativo) de toda a organização"},
            };
        }
    }
}