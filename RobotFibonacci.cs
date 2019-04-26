using System;
namespace laboratorio5
{
    public class RobotFibonacci : ICalcular
    {
        private int CalcularFibonacci(int numero) {
            if (numero == 0)
            {
                return 0;
            }
            if (numero == 1)
            {
                return 1;
            }
            return CalcularFibonacci(numero - 1) + CalcularFibonacci(numero - 2);
        }

        public int Calcular(int numero)
        {
            numero = Math.Max(0, numero); // Para evitar trabajar con números negativos
            numero = Math.Min(numero, 10); // Para evitar trabajar con números tan grandes
            return CalcularFibonacci(numero);
        }

        public string GetNombre()
        {
            return "Calcular Fibonacci";
        }
    }
}
