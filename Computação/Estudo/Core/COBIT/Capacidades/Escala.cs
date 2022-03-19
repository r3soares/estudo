using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computacao.COBIT
{
    public struct Escala
    {
        public string Nome { get; init; }
        public string Descricao { get; init; }
        public int RealizacaoMinima { get; init; }
        public int RealizacaoMaxima { get; init; }
    }
}