using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interface001.Entitides
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxacao { get; set; }

        public Fatura(double pagamentoBasico, double taxacao)
        {
            PagamentoBasico = pagamentoBasico;
            Taxacao = taxacao;
        }
        //metodo para calcular valores pagos + taxa de imposto
        public double TotalPagamento
        {
            get
            {
                return PagamentoBasico + Taxacao;
            }
        }

        public override string ToString()
        {
            return "Pagamento Basico " + 
                PagamentoBasico.ToString("F2",CultureInfo.InvariantCulture)
                + "\nTaxa: " 
                + Taxacao.ToString("F2",CultureInfo.InvariantCulture)
                + "\n Total Pagamento "
                + TotalPagamento.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
