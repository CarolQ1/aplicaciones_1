using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1ApliConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            String cp1;
            int cp2;
            Char matematicas;
            Console.WriteLine("-------------");
            Console.WriteLine("LOGIN");
            Console.WriteLine("--------------");
            Console.WriteLine("Escribe tu usuario o correo");
            cp1 = Console.ReadLine();
            Console.WriteLine("Escriba su contraseña");
            int.TryParse(Console.ReadLine(), out cp2);
            //?: //condicional de tipo ternaria
            if (cp1 == "admin" && cp2 == 1234)
            {
                Console.Clear();
                Console.WriteLine("///**///**");
                Console.WriteLine(" Escoge una opción");
                Console.WriteLine("1. sumar");
                Console.WriteLine("2. restar");
                Console.WriteLine("3. multiplicar");
                Console.WriteLine("4.dividir");
                Console.WriteLine("///**///**");
                int opciones = int.Parse(Console.ReadLine());
                switch () {
                    case  1:
                        Console.WriteLine("Escribe el primer numero");
                        double primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        double segundo = Double.Parse(Console.ReadLine());
                        Operaciones operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tu resultado es: " + operaciones.sumar().ToString());
                        Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("Escribe el primer numero");
                        primero = Double.Parse(Console.ReadLine()); //ya no es necesario identificarlos con el double
                        Console.WriteLine("Escribe el segundo numero");
                        segundo = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);//igual caso que el double
                        Console.WriteLine("Tu resultado es: " + operaciones.restar().ToString());
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Escribe el primer numero");
                        primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        segundo = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tu resultado es: " + operaciones.multiplicar().ToString());
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Escribe el primer numero");
                        primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        segundo = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tu resultado es: " + operaciones.dividir().ToString());
                        Console.ReadLine();
                        break;

                }

                /*Console.WriteLine("Inició su login");
                Console.Clear();
                Console.WriteLine("Funciones aritmeticas");
                Char.TryParse(Console.ReadLine(), out matematicas);
                switch (matematicas) {
                    case '1': 
                        {
                            Console.WriteLine("sumar");
                            Console.ReadLine();
                        }break;
                    case '2':
                        {
                            Console.WriteLine("multiplicar");
                            Console.ReadLine();
                        }
                        break;
                    case '3':
                        {
                            Console.WriteLine("dividir");
                            Console.ReadLine();
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("No puede acceder a su login");
                Console.ReadLine();
            }*/
            }
        }
    }
}
