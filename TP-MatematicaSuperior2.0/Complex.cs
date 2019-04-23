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
                        this.argumento = Math.Atan2(this.b, -this.a) + 2 * Math.PI;
                    } else if(this.a < 0 && this.b < 0)
                    {
                        this.argumento = Math.Atan2(-this.b, -this.a) + Math.PI;
                    }
                }
            }  
            
        }

        public Complex binomialToPolar()
        {
            this.setModulo();
            this.setArgumento();

            return this;
        }

        public Complex polarToBinomial()
        {
            this.a = this.modulo * Math.Cos(this.argumento);
            this.b = this.modulo * Math.Sin(this.argumento);

            return this;
        }

    }
}
