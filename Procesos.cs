using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Áreas
{
    public class Procesos
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double cuadrado()
        {
            return num1 * num1;
        }
        public double triangulo()
        {
            return (num1 * num2) / 2;
        }
        public double circulo()
        {
            return (num1 * num1) * 3.1416; 
        }
    }
}