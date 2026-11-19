using System;
using System.Collections.Generic;
using System.Text;

namespace LavaRapido
{
    internal class Registro
    {
        public Veiculo Veiculo { get; set; } = new();
        public Servico Servico { get; set; } = new();
        public decimal ValorTotal { get; set;  }

        public DateTime DataHora { get; set; }
    }
}
