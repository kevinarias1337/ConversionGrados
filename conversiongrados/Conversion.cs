using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiongrados
{
    public class Conversion
    {
        private double grados;

        public void setGrados(double valor)
        {
            this.grados = valor;
        }

        public double getGrados()
        {
            return this.grados;
        }

        public double convertirFarenheit()
        {
            return (this.getGrados()*9/5+32);
        }

        public double convertirCelcius()
        {
            return (this.getGrados()-32)*5/9;
        }
    }
}