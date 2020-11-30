using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS
{
    class Func
    {

        public int Id { get; private set; }
        public string Name  { get; private set; }
        public double Salary { get; private set; }
        
        public Func(int id, string name, double salary)
        {
            Id = id; Name = name; Salary = salary;
        }

        public void IncrementaSalario(double incremento)
        {
            Salary += (Salary * 10) / 100;
        }
        
    }
}
