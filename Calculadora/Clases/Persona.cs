using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Clases
{
    internal class Persona
    {
        private string nombre="";
        private string apellido="";
        private DateTime fecha;
        private int edad;

        public string Nombre { get =>  nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public int Edad
        {
            get => edad = DateTime.Now.Year - Fecha.Year;
            set => edad = value;
        }
    }
}
