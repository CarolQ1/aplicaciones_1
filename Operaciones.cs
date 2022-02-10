using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1ApliConsola
{
    class Operaciones
    {
        double valora, valorb;

        public Operaciones(double valora, double valorb) {
            this.valora = valora;
            this.valorb = valorb;
        }

        public double sumar() {
            return valora + valorb;
        }

        public double restar()
        {
            return valora - valorb;
        }

        public double multiplicar()
        {
            return valora * valorb;
        }

        public double dividir()
        {
            return valora / valorb;
        }
    }
}
