using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tarea1progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- salir");
                Console.Write("Digite una opcion ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Ejercicio1();
                            break;
                    case 2: Ejercicio2();
                            break;
                    case 3: Ejercicio3();
                            break;
                    default:
                        break;
                }
            } while (opcion != 4);//Mientras la opcion sea diferente de 4

        }
        public static void Ejercicio1() //metodo 1
        {
            float precio = 0;   
            int cantidad = 0;
            float total = 0;    

            Console.WriteLine("Cual es el precio de la camisa");
            precio = float.Parse(Console.ReadLine());   
            Console.WriteLine("Cuantas desea llevar");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar: {cantidad * precio}");
            }

            if (cantidad > 2 && cantidad < 5)
            {
                total = (cantidad * precio) * 0.15f; //Calcula el 15 porcineto
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: {total} con descuento de 15%");
            }
            if (cantidad >= 5)
            {
                total = (cantidad * precio) * 0.20f; //Calcula el 20 porcineto
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: {total} con descuento de 20%");
            }
        }    
        public static void Ejercicio2() //metodo 2
        {
            Console.WriteLine("Ingrese el carnet de estudiante ");
            string carnet = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante ");
            string nombre = Console.ReadLine();
            //  Ingresar los quices 
            Console.WriteLine("Ingrese la nota del quiz 1 ");
            float quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del quiz 2 ");
            float quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del quiz 3 ");
            float quiz3 = float.Parse(Console.ReadLine());
            // Ingresar las tareas
            Console.WriteLine("Ingrese la nota de la tarea 1 ");
            float tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tarea 2 ");
            float tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tarea 3 ");
            float tarea3 = float.Parse(Console.ReadLine());
            // Ingresar la nota de los examenes 
            Console.WriteLine("Ingrese la nota del examen 1 ");
            float examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen 2 ");
            float examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen 3 ");
            float examen3 = float.Parse(Console.ReadLine());
            // Ahora voy a calcular los porcentajes
            float porcentajedelosquices = ((quiz1 + quiz2 + quiz3) / 3) * 0.25f;
            float porcentajedetareas = ((tarea1 + tarea2 + tarea3) / 3) * 0.30f; 
            float porcentajedeexamenes = ((examen1 + examen2 + examen3) / 3) * 0.45f; 
            float promediofinal = porcentajedelosquices + porcentajedetareas + porcentajedeexamenes;

            string condicion = "";
            if (promediofinal >= 70 )
            {
                condicion = "Aprobado";
            }
            else if (promediofinal >= 50 && promediofinal < 70)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Carnet del estudiante: " + carnet);
            Console.WriteLine("Nombre del estudiante: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajedelosquices + "%");
            Console.WriteLine("Porcentaje de Tareas: " + porcentajedetareas + "%");
            Console.WriteLine("Porcentaje de Examenes: " + porcentajedeexamenes + "%");
            Console.WriteLine("Promedio Final: " + promediofinal);
            Console.WriteLine("Condición del estudiante: " + condicion);
        }
        public static void Ejercicio3() //metodo 3
        {
            Console.WriteLine("Ingrese la cantidad de articulos a comprar ");
            float cantidad = float.Parse(Console.ReadLine());
            float preciodelArticulo;
            float total = 0;    
            if (cantidad <= 10)
            {
                preciodelArticulo = 20.0f;
                total = cantidad * preciodelArticulo;
                Console.WriteLine($"El precio por artículo es: ${preciodelArticulo}");
                Console.WriteLine($"El total a pagar es: ${total}");
            }
            if (cantidad > 10)
            {
                preciodelArticulo = 15.0f;
                total = (cantidad * preciodelArticulo);
                Console.WriteLine($"El precio por artículo es: ${preciodelArticulo}");
                Console.WriteLine($"El total a pagar es: ${total}");
            }


        }
    }
}
