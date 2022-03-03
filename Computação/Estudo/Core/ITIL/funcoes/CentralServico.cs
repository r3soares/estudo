using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Core.ITIL
{
    /// <summary>
    /// Central de Serviço não é help desk! Um help desk tem como característica natural o fato de ser 
    //  reativo(só age se provocado). A central deve ser também proativa, interagindo com os
    //  sistemas/monitorações para internalizar, entre outros, os incidentes e as requisições de serviço de
    //  forma proativa, antes que o serviço de TI venha a ser degradado e esta degradação seja percebida
    //  pelo cliente
    /// </summary>
    public class CentralServico : Funcao
    {
        public string[] Tipos { get; init; }

        public CentralServico()
        {
            Tipos = new string[]
            {
                "Local",
                "Centralizada",
                "Virtual" //Conhecida como Follow the Sun
            };
        }
    }
}
