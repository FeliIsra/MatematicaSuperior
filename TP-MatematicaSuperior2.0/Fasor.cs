using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatematicaSuperior2._0
{
    class Fasor{

        string tipo = "";

        public string getTipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        double amplitud = 0;

        public double getAmplitud
        {
            get { return amplitud; }
            set { amplitud = value; }
        }
        double frecuencia = 0;

        public double getFrecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }
        double angulo = 0;

        public double getAngulo
        {
            get { return angulo; }
            set { angulo = value; }
        }

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

        public Fasor sumaDeFasores(Fasor unFasor, Fasor otroFasor) 
        {
            if (unFasor.frecuencia == otroFasor.frecuencia && unFasor.tipo == otroFasor.tipo)
            {
                Complex unComplejo = convertirAComplejo(unFasor);
                Complex otroComplejo = convertirAComplejo(otroFasor);

                unComplejo.addComplex(otroComplejo);    

                return new Fasor(unFasor.tipo, unComplejo.getModulo(), unFasor.frecuencia, unComplejo.getArgumento());
            } else
            {
                if (unFasor.frecuencia == otroFasor.frecuencia && unFasor.tipo != otroFasor.tipo)
                {
                    if (unFasor.tipo == "sen")
                    {
                        unFasor.tipo = "cos";
                        unFasor.angulo -= Math.PI / 2;
                    }
                    else
                    {
                        otroFasor.tipo = "cos";
                        otroFasor.angulo -= Math.PI / 2;
                    }
                    Complex unComplejo = convertirAComplejo(unFasor);
                    Complex otroComplejo = convertirAComplejo(otroFasor);

                    unComplejo.addComplex(otroComplejo);

                    return new Fasor(unFasor.tipo, unComplejo.getModulo(), unFasor.frecuencia, unComplejo.getArgumento());
                }
                else
                {
                    return new Fasor("no", -1, -1, -1); //Error
                }
            }
        }

    }
}
