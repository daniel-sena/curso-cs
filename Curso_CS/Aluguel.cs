using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_CS
{
    class Aluguel
    {
        //Atributos Privados
        //Propriedades Autoimplementadas
        public String Nome { get; private set; }
        public String Email { get; private set; }
        public int Quarto { get; private set; }
        //Construtores
        public Aluguel(String nome, String email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }
        //Propriedades Customizadas
        //Outros Métodos de Classes
        public override string ToString()
        {
            return "Quarto #:" + Quarto + ", " +Nome +", "+ Email ;
        }


    }
}
