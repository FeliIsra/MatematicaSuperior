using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatematicaSuperior2._0
{
    class Complex{

        double a = 0;
        double b = 0;
        double modulo = 0;
        double argumento = 0;

        public Complex (double _a, double _b)
        {
            a = _a;
            b = _b;
        }
    
        
        public void setBinomial(double _a, double _b)
        {
            this.a = _a;
            this.b = _b;
        }

        public void setPolar(double _module, double _grade)
        {
            this.modulo= _module;
            this.argumento = _grade;
        }

        public double getModulo()
        {
            return this.modulo;
        }

        public double getArgumento()
        {
            return this.argumento;
        }

        public double getA()
        {
            return this.a;
        }

        public double getB()
        {
            return this.b;
        }

        public void setModulo(){
            this.modulo = Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2));
        }

        public void setArgumento()
        {
          
          if(this.a >=0 && this.b >= 0){
                this.argumento = Math.Atan2(this.b, this.a);
          } else
            {
                if(this.a >= 0 && this.b < 0)
                {
                    this.argumento = Math.Atan2(-this.b, -this.a) + Math.PI;
                } else
                {
                    if(this.a < 0 && this.b >= 0)
                    {
                        this.argumento = Math.Atan2(this.b, -this.a) + Math.PI / 2;
                    } else if(this.a < 0 && this.b < 0)
                    {
                        this.argumento = Math.Atan2(-this.b, -this.a) + Math.PI;
                    }
                }
            }  
            
        }

        public void binomialToPolar()
        {
            this.setModulo();
            this.setArgumento();

        }

        public void polarToBinomial()
        {
            this.a = this.modulo * Math.Cos(this.argumento);
            this.b = this.modulo * Math.Sin(this.argumento);

         
        }

        public Complex addComplex(Complex _complex)
        {
            return new Complex(this.a + _complex.a, this.b + _complex.b);
        }

        /**
         * Resta al número complejo otro número complejo
         * @param _complex Número complejo de la resta
         * @return Objeto Complex
         */
        public Complex substractComplex(Complex _complex)
        {
            return new Complex(this.a - _complex.a, this.b - _complex.b);
        }

        /**
         * Multiplica al número complejo otro número complejo
         * @param _complex Número complejo de la multiplicación
         * @return Objeto Complex
         */
        public Complex multiplyComplex(Complex _complex)
        {
            return new Complex((this.a * _complex.a - this.b * _complex.b),
                    (this.a * _complex.b + this.b * _complex.a));
        }

        /**
         * Divide el número complejo actual entre el valor del parámetro
         * @param _complex Denominador
         * @return Objeto Complex
         */
        public Complex divideComplex(Complex _complex)
        {
            return divideComplex(this, _complex);
        }

        /**
         * Divide dos números complejos
         * @param _complex1 Numerador
         * @param _complex2 Denominado
         * @return Objeto Complex
         */
        public Complex divideComplex(Complex _complex1, Complex _complex2)
        {
            double xx = (_complex1.a * _complex2.a + _complex1.b * _complex2.b) / (Math.Pow(_complex2.a, 2) + Math.Pow(_complex2.b, 2));
            double yy = (_complex1.b * _complex2.a - _complex1.a * _complex2.b) / (Math.Pow(_complex2.a, 2) + Math.Pow(_complex2.b, 2));
            return new Complex(xx, yy);
        }

        public Complex potencia(Double n)
        {
            Complex resp = new Complex(0, 0);
            resp.setPolar(Math.Pow(this.modulo, n),this.argumento * n);
            return resp;
        }

        public Complex raiz(Double n)
        {
            Complex resp = new Complex(0, 0);
            resp.setPolar(Math.Pow(this.modulo, (1 / n)), (this.argumento) / n );
            return resp;
        }

        public Complex conjugate(Complex complex)
        {
            return new Complex(complex.a, -complex.b);
        }

        /**
         * Calcula el opuesto de un número complejo
         * @return Objeto Complex
         */
        public Complex opposite()
        {
            return opposite(this);
        }

        /**
         * Calcula el opuesto de un número complejo
         * @param _complex Número complejo
         * @return Objeto Complex
         */
        public Complex opposite(Complex _complex)
        {
            return new Complex(-_complex.a, -_complex.b);
        }
        /**
         * Obtiene el conjugado de un número complejo
         * @return Objeto Complex
         */
        public Complex conjugate()
        {
            return conjugate(this);
        }

        public bool isEmpty()
        {
            return (this.a == null || this.b == null);
        }

    }
}
