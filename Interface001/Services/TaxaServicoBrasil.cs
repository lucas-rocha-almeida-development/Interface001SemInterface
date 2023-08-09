using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface001.Services
{
    internal class TaxaServicoBrasil : ITaxaServico{
        public double Taxa(double quantia)
        { if(quantia <= 100.0)
            {
                return quantia * 0.2;

            }
              else { 
                
                return quantia * 0.15; 
            
            } 


        }
        
    }
}
