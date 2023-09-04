using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Intereses
    {
        public Intereses() 
        {
            tiempo = 0;
            interes = 0;
            ValorFinal = 0;
            ValorInicial = 0;
            Resultado = 0;
            dias = 0;
            meses = 0;
            años = 0;
        }
        public int tiempo { get; set; }
        public double interes { get; set; }
        public double ValorInicial { get; set; }
        public double ValorFinal { get; set; }
        public double Resultado { get; set; }
        public int dias { get; set; }
        public int meses { get; set; }
        public int años { get; set; }

    }
}
