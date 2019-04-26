using System;
namespace laboratorio5
{
    public class PerroFactorial : ICalcular
    {
        private int CalcularFactorial(int numero)
        {
            if (numero <= 1) {
                return 1;
            }
            return numero * CalcularFactorial(numero - 1);
        }

        public int Calcular(int numero)
        {
            numero = Math.Max(0, numero); // Para evitar trabajar con números negativos
            numero = Math.Min(numero, 7); // Para evitar trabajar con números tan grandes
            return CalcularFactorial(numero);
        }

        public string GetNombre()
        {
            return "Obtener factorial";
        }
    }
}
