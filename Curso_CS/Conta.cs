using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS
{
    class Conta
    {
        //atributos privados 

        // Propriedades autoimplementadas
        public String Titular { set; get; }
        public double Saldo { private set; get;}
        public int Numero { private set; get; }

        //Construtores
        public Conta(int numero,String titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public Conta(int numero,String titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }
        //Propriedades Customizadas

        // Outros Métodos
        public void Saque(double valor)
        {
            if (valor > 0)
            {
                Saldo -= (valor + 5.0);
            }
        }
        public void Deposito(double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
            }
        }

        public override string ToString()
        {
            return "Numero: " + Numero + " Titular: " + Titular + " Saldo: " + Saldo;
        }

    }
}
