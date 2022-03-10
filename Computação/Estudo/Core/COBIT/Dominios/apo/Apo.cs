using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COBIT
{
    //Dominio para a Gestão Empresaria de TI
    public class Apo : Dominio
    {
        public Apo()
        {
            Nome = "Alinhar, Planejar e Monitorar";
            Sigla = "APO";
            Objetivo = "";
            Processos = new Processo[13]
            {
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
                new Processo(),
            };
        }
    }
}