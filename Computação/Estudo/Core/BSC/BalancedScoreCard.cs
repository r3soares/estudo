using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computacao.BSC
{
    public class BalancedScoreCard
    {
        public Dimensao Financeira { get; init; }
        public Dimensao Cliente { get; init; }
        public Dimensao Interna { get; init; }
        public Dimensao TreinamentoCrescimento { get; init; }
    }
}