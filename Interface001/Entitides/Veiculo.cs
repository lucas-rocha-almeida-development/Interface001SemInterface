using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface001.Entitides
{
    internal class Veiculo
    {
        public string Modelo { get; set; }


        //construtor vazio
        public Veiculo(string modelo)
        {

            Modelo = modelo;
        }
    }
}
