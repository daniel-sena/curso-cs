using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double CalculaArea()
        {
            double p = CalculaP();
            return ( Math.Sqrt( p * (p - A) * (p - B) * (p - C) ) );
        }
        double CalculaP()
        {
            return (double)((A + B + C) / 2);
        }
    }
    
}
