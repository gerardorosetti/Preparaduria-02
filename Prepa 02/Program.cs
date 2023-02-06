using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Punto my_punto = new Punto();
                        Punto my_punto_2 = new Punto(6,8);

                        my_punto.SetX(10);
                        my_punto.SetY(5);

                        my_punto_2.SetX(20);
                        my_punto_2.SetY(45);

                        Console.WriteLine($"Mi valor en x es: {my_punto.GetX()}\nMi valor en y es: {my_punto.GetY()}");
                        Console.WriteLine("Mi valor en x es: {0}\nMi valor en y es: {1}", my_punto_2.GetX(), my_punto_2.GetY());
            */

            Vector my_vector = new Vector(0,0,4,3);
            Vector my_vector_2 = new Vector(0,0,4,3);

            Vector my_vector_3 = my_vector + my_vector_2;
            my_vector += my_vector_2;


            Console.WriteLine($"Mi magnitud es de: {my_vector_3.get_magnitud()}");
            Console.ReadLine();
        }
    }
}
