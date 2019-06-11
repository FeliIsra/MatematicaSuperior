using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatematicaSuperior2._0
{
    class Fasor{

        string tipo = "";
        double amplitud = 0;
        double frecuencia = 0;
        double angulo = 0;

        public Fasor(string  _tipo, double _amplitud, double _frecuencia, double _angulo)
        {
            tipo = _tipo;
            amplitud = _amplitud;
            frecuencia = _frecuencia;
            angulo = _angulo;
        }

        public Complex convertirAComplejo(Fasor miFasor)
        {
            return new Complex(0, 0, miFasor.amplitud, miFasor.angulo);
            
        }

        public Fasor sumaDeFasores(Fasor unFasor, Fasor otroFasor) //si ambos son de mismo tipo
        {
            if (unFasor.frecuencia == otroFasor.frecuencia && unFasor.tipo == otroFasor.tipo)
            {
                Complex unComplejo = convertirAComplejo(unFasor);
                Complex otroComplejo = convertirAComplejo(otroFasor);

                unComplejo.addComplex(otroComplejo);    

                return new Fasor(unFasor.tipo, unComplejo.modulo, unFasor.frecuencia, unComplejo.argumento);
            } else
            {
                return new Complex(-1, -1, -1, -1); //Error
            }
        }

    }
}
