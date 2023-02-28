using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTemperatura
{
    /// <summary>
    /// Nombre: Laura Serena Rivera Mejía
    /// Fecha: 24-02-2023
    /// Descripción: Este programa convierte temperatura de Celsius o Fahrenheit o viceversa.
    /// </summary>


    internal class Program
    {
        static void Main(string[] args)
        {

            //Declara variables
            double Temperatura;
            int Opcion;
            //Mensaje de salida
            Console.WriteLine("Por favor elija una de las siguientes opciones");
            Console.WriteLine("1. Convertir temperatura de Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir temperatura de Fahrenheit a Celsius");

            //Conversión, dato de entrada.
            Opcion = Convert.ToInt16(Console.ReadLine());

            //Mensaje de salida
            Console.WriteLine("Ingrese la temperatura");

            //Conversión, dato de entrada.
            Temperatura = Convert.ToDouble(Console.ReadLine());

            //Ciclo lógico

            if (Opcion == 1)
            {
                Console.WriteLine("La temperatura en Fahrenheit es " + CalcularCelsius(Temperatura) + "°");
            }
            else if (Opcion == 2)
            {
                Console.WriteLine("La temperatura en Celsius es " + CalcularFahrenheit(Temperatura) + "°");
            }

            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();



        }


        //Método 1
        static double CalcularCelsius(double Temperatura)
        {

            double Celsius;
            Celsius = (Temperatura * 1.8) + 32;
            return Celsius;

        }
        //Método 2
        static double CalcularFahrenheit(double Temperatura)
        {

            double Fahrenheit;
            Fahrenheit = (Temperatura - 32) / 1.8;
            return Fahrenheit;

        }



    }












}
