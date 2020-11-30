using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS
{
    class Funcionario
    {
        private double _salario;
        public String Nome { get; set; }

        public double GetSalario()
        {
            return _salario;
        }
        public double Salario
        {
            get { return _salario; }
            set
            {
                if (value > 0)
                {
                    _salario = value;
                }
            }

        }


        public override string ToString()
        {
            return "Nome: " + Nome + " Salario: " + _salario;
        }
    }


}
