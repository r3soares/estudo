
namespace COBIT
{
    //Versão Cobit 5
    public class Cobit
    {
        public string Descricao { get; init; }
        public string[] Caracteristicas { get; init; }

        public Cobit()
        {
            Descricao = "Framework completo e aceito internacionalmente para governança e gerenciamento corporativo de TI";
            Caracteristicas = new string[]
            {
                "Focado no negócio",
                "Orientado a processos",
                "Utiliza métricas e modelos orientados a processos",
                "Não é uma metodologia",
                "Trata a governança de forma holística",
                "Pode ser usado por organizações de todos os portes",
                "Genérico para representar todos os processos comuns de TI",
            };
        }
    }
}