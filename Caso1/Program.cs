using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso1
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Pilas...");

                Stack<string> Pila = new Stack<string>();

                // Usamos push
                Pila.Push("Programa 1, suma");
                Pila.Push("Programa 2, resta");
                Pila.Push("Programa 3, multiplica");
                Pila.Push("Programa 4, suma");
                Pila.Push("Programa 5, resta");

                // Recorremos los elementos
                foreach (var elem in Pila)
                {
                    Console.WriteLine(elem);
                }
                Console.WriteLine("");


                // Eliminar el primer elemento
                Pila.Pop();

                foreach (var elem in Pila)
                {
                    Console.WriteLine(elem);
                }
                Console.WriteLine("");

                //Obtenemos el valor del primer elemento
                Console.WriteLine(Pila.Peek());
                Console.WriteLine("");
                //Console.Read();

            }
        }
    }
}