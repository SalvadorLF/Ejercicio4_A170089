using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Áreas
{
    /// <summary>
    /// Descripción breve de Areas_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Areas_WebService : System.Web.Services.WebService
    {
        Procesos c = new Procesos();

        [WebMethod]
        public double cuadrado(double l)
        {
            c.num1 = l;
            return c.cuadrado();
        }
        [WebMethod]
        public double triangulo(double b, double a)
        {
            c.num1 = b;
            c.num2 = a;
            return c.triangulo();
        }
        [WebMethod]
        public double circulo(double r)
        {
            c.num1 = r;
            return c.circulo();
        }
    }
}