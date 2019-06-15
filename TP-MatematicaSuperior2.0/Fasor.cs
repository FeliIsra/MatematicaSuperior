using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatematicaSuperior2._0
{
    class Fasor{

        string tipo = "";

        public string getTipo()
        {
            return tipo;
        }
        public void setTipo(string value){
             tipo = value;
        }
        double amplitud = 0;

        public double getAmplitud()
        {
            return amplitud;
        }
        public void setAmplitud(double value)
        {
            amplitud = value;
        }
        double frecuencia = 0;

        public double getFrecuencia()
        {
            return frecuencia;
        }
        public void setFrecuencia(double value)
        {
            frecuencia = value;
        }
        double angulo = 0;

        public double getAngulo()
        {
            return angulo;
        }
        public void setAngulo(double value)
        {
            angulo = value;
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
            return new Complex(0, 0, miFasor.getAmplitud(), miFasor.getAngulo());
            
        }

        public Fasor sumaDeFasores(Fasor unFasor, Fasor otroFasor) 
        {
            if (unFasor.frecuencia == otroFasor.frecuencia && unFasor.tipo == otroFasor.tipo)
            {
                Complex unComplejo = convertirAComplejo(unFasor);
                Complex otroComplejo = convertirAComplejo(otroFasor);
                unComplejo.polarToBinomial();
                otroComplejo.polarToBinomial();

                Complex suma = unComplejo.addComplex(otroComplejo);
                /*double amp = Math.Sqrt(Math.Pow(unFasor.getAmplitud(), 2) + Math.Pow(otroFasor.getAmplitud(), 2));
                double arg = Math.Atan(otroComplejo.getB() / unComplejo.getB());*/
                suma.binomialToPolar();

                return new Fasor(unFasor.getTipo(), suma.getModulo(), unFasor.getFrecuencia(), suma.getArgumento());
            } else
            {
                if (unFasor.frecuencia == otroFasor.frecuencia && unFasor.tipo != otroFasor.tipo)
                {
                    if (unFasor.getTipo() == "sen")
                    {
                        unFasor.setTipo("cos");
                        unFasor.setAngulo(unFasor.getAngulo() - (Math.PI / 2));
                    }
                    else
                    {
                        otroFasor.setTipo("cos");
                        otroFasor.setAngulo(otroFasor.getAngulo() - (Math.PI / 2));
                    }
                    Complex unComplejo = convertirAComplejo(unFasor);
                    Complex otroComplejo = convertirAComplejo(otroFasor);
                    unComplejo.polarToBinomial();
                    otroComplejo.polarToBinomial();

                    Complex suma = unComplejo.addComplex(otroComplejo);
                    /*double amp = Math.Sqrt(Math.Pow(unFasor.getAmplitud(), 2) + Math.Pow(otroFasor.getAmplitud(), 2));
                    double arg = Math.Atan(otroComplejo.getB() / unComplejo.getB());*/
                    suma.binomialToPolar();

                    return new Fasor(unFasor.getTipo(), suma.getModulo(), unFasor.getFrecuencia(), suma.getArgumento());
                }
                else
                {
                    return new Fasor("no", -1, -1, -1); //Error
                }
            }
        }

    }
}
