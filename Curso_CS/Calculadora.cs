using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Curso_CS
{
    static class Calculadora
    {
        public static int Soma(params int[] fatores)
        {
            int soma = 0;
            foreach(int i in Enumerable.Range(1, fatores.Length))
            {
                soma += fatores[i-1];
            }
            return soma;
        }
        public static double Soma(params double[] fatores)
        {
            double soma = 0;
            foreach (int i in Enumerable.Range(1, fatores.Length))
            {
                soma += fatores[i - 1];
            }
            return soma;
        }
    }
}
