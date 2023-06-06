// Importar os namespaces necessários
using System;
using System.Globalization;

// Declaração da classe Triangulo
namespace Course
{
    public class Triangulo
    {
        // Propriedades para os lados do triângulo
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Método para calcular a área do triângulo
        public double CalcularArea()
        {
            // Cálculo do semi-perímetro
            double p = (A + B + C) / 2.0;

            // Cálculo da área usando a fórmula de Heron
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            // Retorno da área calculada
            return area;
        }
    }

    // Declaração da classe Program
    public class Program
    {
        // Método principal
        public static void Main(string[] args)
        {
            // Leitura dos triângulos X e Y
            Triangulo x = LerTriangulo("x");
            Triangulo y = LerTriangulo("y");

            // Cálculo das áreas
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            // Impressão das áreas com formatação
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // Comparação das áreas e impressão do resultado
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        // Método para ler os lados do triângulo
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            // Criação de um novo objeto Triangulo
            Triangulo triangulo = new Triangulo();

            // Solicitação das medidas do triângulo ao usuário
            Console.Write("Entre com as medidas do triângulo " + nomeTriangulo + ": ");
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Retorno do objeto Triangulo com as medidas lidas
            return triangulo;
        }
    }
}
