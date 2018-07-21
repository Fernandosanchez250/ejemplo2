/*
 *Programación | Mtro. Iván Vega
 * Fecha: 12/03/2018
 * Oxxo Izamal tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)
Desarrollar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
Imprimir los gastos en sueldos de cada turno.
 * 
 */
using System;

namespace arregosOxxo
{
	class Program
	{
		public static void Main(string[] args)
		{
			float[] turnoM; //Declaramos un vector para el turno mañana
			float[] turnoT; //Declaramos un vector para el turno tarde
			
			string linea;
            turnoM = new float[4]; //Asignamos al vector una de longitud 4
            turnoT = new float[4]; //Asignamos al vector una de longitud 4
            Console.WriteLine("Sueldos de empleados del turno de la mañana.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo "+(f+1)+": ");
                linea = Console.ReadLine();
                turnoM[f] = float.Parse(linea); //Asignamos valores al vector turno mañana
            }
            Console.WriteLine("Sueldos de empleados del turno de la tarde.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo "+(f+1)+": ");
                linea = Console.ReadLine();
                turnoT[f] = float.Parse(linea); //Asignamos valores al vector turno tarde
            }
			// Calcular gasto
			
			float man = 0;
            float tar = 0;
            for (int f = 0; f < 4; f++)
            {
               man = man + turnoM[f]; //Realizamos la suna de los valores del vector turno Mañana
               tar = tar + turnoT[f]; //Realizamos la suna de los valores del vector turno Tarde
            }
            Console.WriteLine("Total de gastos del turno de la mañana:" + man);
            Console.WriteLine("Total de gastos del turno de la tarde:" + tar);
            Console.ReadKey();
            
		}
	}
}