using DevTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
                string opcion;
                Console.WriteLine("Eliga una opción: (Circulo o Rectangulo)");
                opcion = Console.ReadLine();
                if (opcion.Trim().ToUpper() == "CIRCULO")
                {
                    int a;
                    Console.WriteLine("Ingrese el radio: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Circle circle = new Circle();
                    Console.WriteLine("El area del circulo es: " + circle.GetArea(a));
                    Console.ReadLine();
                }
                else if (opcion.Trim().ToUpper() == "RECTANGULO")
                {
                    int a,b;
                    Console.WriteLine("Ingrese el Ancho: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el Alto: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("El area del rectangulo es: " + rectangle.GetArea(a,b));
                    Console.ReadLine();
                }
            } while (salir == false);
        }
    }
}
