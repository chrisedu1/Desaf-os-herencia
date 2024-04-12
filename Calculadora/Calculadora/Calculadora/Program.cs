using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese el primer número:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese el segundo número:");
            double n2 = double.Parse(Console.ReadLine());
            Calculadora calc = new Calculadora("Casio", "Rolex");
            Console.WriteLine("===============");
            Console.WriteLine("Suma");
            double total = calc.Sumar(n1, n2);
            Console.WriteLine(total);

            Console.WriteLine("===============");
            Console.WriteLine("Resta");
            double diferencia = calc.Restar(n1, n2);
            Console.WriteLine(diferencia);

            Console.WriteLine("===============");
            Console.WriteLine("Multiplicación");
            double producto = calc.Multiplicar(n1, n2);
            Console.WriteLine(producto);

            Console.WriteLine("===============");
            Console.WriteLine("División");
            double division = calc.Dividir(n1, n2);
            Console.WriteLine(division);

            

            CalculadoraCientifica cientifica = new CalculadoraCientifica("Xiaomi", "Samsung");
            Console.WriteLine("===============");
            Console.WriteLine("Raíz Cuadrada");
            double raiz = cientifica.Raíz(n1);
            Console.WriteLine(raiz);

            Console.WriteLine("===============");
            Console.WriteLine("Potencia");
            double potencia = cientifica.Potencia(n1, n2);
            Console.WriteLine(potencia);

            Console.WriteLine("===============");
            Console.WriteLine("Modulo");
            double modulo = cientifica.Modulo(n1, n2);
            Console.WriteLine(modulo);

            Console.WriteLine("===============");
            Console.WriteLine("Logaritmo");
            double log = cientifica.Logaritmo(n1, n2);
            Console.WriteLine(log);

            Console.ReadLine();

        }
    }

    public class Calculadora
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Restar(double n1, double n2) 
        {
            return n1 - n2;
        }
        public double Multiplicar(double n1, double n2) 
        { 
        return n1 * n2;
        }
        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }

    public class CalculadoraCientifica : Calculadora
    {

        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }

        public double Potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
        public double Raíz(double n1)
        {
            return Math.Sqrt(n1);
        }
        public double Modulo(double n1, double n2)
        {
            return n1 % n2;
        }
        public double Logaritmo(double n1, double n2)
        {
            return Math.Log(n1, n2);
        }
    }
}
