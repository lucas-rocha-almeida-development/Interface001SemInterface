using Interface001.Entitides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface001.Services
{
    internal class ServicoAluguel
    {
        //serviço de aluguel
        public double  PrecoPorHora { get; private set; }//somente obter not modificar
        public double PrecoPorDia { get; private set; }//somente obter not modificar

        private ITaxaServico _taxaimposto;


        //construtor
        public ServicoAluguel(double precoPorHora, double precoPorDia,ITaxaServico taxaimposto)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaimposto = taxaimposto;
        }
        //metodo 
        public void ProcessamentoPagamento (AluguelCarro carroaluguel)
        {
            //implementar o processamento do carro alugado
            //para gerar nota de pagamento
            TimeSpan duracao = carroaluguel.Fim.Subtract(carroaluguel.Inicio);

            double basicoPagamento = 0.0;

            if (duracao.TotalHours <= 12.0)
            {
                basicoPagamento = PrecoPorHora * Math.Ceiling(duracao.TotalHours);//ira arredondar valor para cima
            }
            else
            {
                basicoPagamento = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            //calcular valor do imposto

            double taxa = _taxaimposto.Taxa(basicoPagamento);

            carroaluguel.Fatura = new Fatura (basicoPagamento, taxa);//processaro a fatura 

        }
    }
}
