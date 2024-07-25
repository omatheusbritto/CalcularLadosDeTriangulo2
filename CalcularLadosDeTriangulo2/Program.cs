// Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
// válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
// possui a maior área.
using CalcularLadosDeTriangulo2;
using System;
using System.Globalization;

namespace MedidaDosLadosDeDoisTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Programa que calcula a medida de dois triangulos");
            Console.WriteLine("Digite os valores do lado do triangulo X");
            Console.WriteLine(" ");
            Console.Write("Digite o valor de A: ");
            x.A= double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            x.B= double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            x.C= double.Parse(Console.ReadLine());


            double areax = heron(x.A, x.B, x.C);
            Console.WriteLine(" ");

            Console.WriteLine("Digite os valores do lado do triangulo Y");
            Console.Write("Digite o valor de A: ");
            y.A = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            y.B = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            y.C = double.Parse(Console.ReadLine());

            double areay = heron(y.A, y.B, y.C); ;

            Console.WriteLine(" ");
            Console.WriteLine("Area do triangulo X = {0:F4}", areax);
            Console.WriteLine("Area do triangulo y = {0:F4}", areay);
            Console.WriteLine(" ");
            if (areax > areay)
            {
                Console.WriteLine("A maior area é a do triangulo X");
            }
            else
            {
                Console.WriteLine("A maior area é a do triangulo Y");
            }
        }
        static double heron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}