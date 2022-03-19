namespace Computacao.ITIL
{
    public class Melhoria : Estagio
    {
        public Dictionary<string,string> Modelo { get; init; }
        public string[] Melhoria7Passos { get; init; }

        public Melhoria()
        {
            Modelo = new Dictionary<string, string>()
            {
                {"Qual é a visão?","Identificar a visão no entendimento do negócio para alinhar as estratégias de TI"},
                {"Onde nós estamos agora?","Definir uma linha base para que seja possível fazer análises e comparações"},
                {"Onde nós queremos estar?","Definir alvos mensuráveis para que sejam alcançados"},
                {"Como nós chegaremos lá?","Definir as melhorias necessárias para atingir os objetivos"},
                {"Chegamos lá?","Avaliar as métricas e medições realizadas para garantir que os marcos foram alcançados"},
                {"Como mantemos o ritmo?","Garantir que a melhoria da qualidade continue"},
            };

            Melhoria7Passos = new string[]
            {
                "1 - Definir o que você deve medir",
                "2 - Definir o que você pode medir",
                "3 - Coletar os dados",
                "4 - Processar os dados",
                "5 - Analisar os dados",
                "6 - Apresentar e usar a informação",
                "7 - Implementar as ações corretivas / melhorias",
            };
        }
    }
}