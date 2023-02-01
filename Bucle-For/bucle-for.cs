using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//mostrar triangulos cuya superficie sea mayor a 12
namespace EjercicioFor 
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant_triangulos,b,a,superficie;
            string linea;    
            cantidad = 0;        
            Console.Write("¿Cuantos triangulos desea ingresar?");
            linea = Console.ReadLine();
            cant_triangulos=int.Parse(linea);
            for(f=1;f<=cant_triangulos;f++)
            {
                Console.Write("Ingrese la base:");
                linea = Console.ReadLine();
                b = int.Parse(linea);
                Console.Write("Ingrese la altura:");
                linea = Console.ReadLine();
                a = int.Parse(linea);
                superficie = (b * a)/2;
                if (superficie>=12)
                {
                    cantidad++;
                }
            }
            Console.Write("De los datos ingresados el numero de triangulos de superficie mayor a 12 son: ");
            Console.Write(cantidad);
            Console.ReadKey();
        }
    }
}