using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1PrograIII
{
    internal class Program
    {
        static void Main(string[] args)
        { }
           public class Persona
        {
            private string nombre;
            private int edad;

            public string Nombre
            {
                get => nombre;
                set => nombre = value;
            }

            public int Edad
            {
                get => edad;
                set => edad = value;
            }
        }

    }
    }
}    
