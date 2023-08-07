using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface001.Entitides;

namespace Interface001.Entitides 
{
    internal class AluguelCarro 
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
