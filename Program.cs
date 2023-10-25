﻿using membrosestaticos;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volu = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volu.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));

        }
        
    }
}