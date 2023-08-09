using Interface001.Entitides;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface001.Services;

namespace Interface001
{
    internal class Program
    {
        //PROGRAMA SEM INTERFACES //METODO NÃO ACONSELHÁVEL 
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do ALUGUEL: " );
            Console.Write("Entre com modelo do VEICULO: ");
            string modelo = Console.ReadLine();
            Console.Write("Saida : (dd/MM/yyyy hh:ss): ");
            DateTime start =  DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.Write("Retorno : (dd/MM/yyyy hh:ss): ");
            DateTime End = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com preço por Hora: ");
            double houras = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entre com preço por Dia: ");
            double Dias = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //fazendo instancia
            AluguelCarro carroaluguel = new AluguelCarro (start,End,new Veiculo(modelo));

            ServicoAluguel servicoAluguel = new ServicoAluguel(houras, Dias, new TaxaServicoBrasil());
            

            servicoAluguel.ProcessamentoPagamento (carroaluguel);

            Console.WriteLine("Fatura: ");
            Console.WriteLine(carroaluguel.Fatura);


        }
    }
}
