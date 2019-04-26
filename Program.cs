using System;

namespace laboratorio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora random");
            Console.WriteLine("Ingresa un numero inicial:");
            int numeroInicial = int.Parse(Console.ReadLine());

            Calculadora miCalculadora = new Calculadora(numeroInicial);

            miCalculadora.calculadoras.Add(new PerroFactorial());
            miCalculadora.calculadoras.Add(new PersonaQueSuma5());
            miCalculadora.calculadoras.Add(new RobotFibonacci());
            miCalculadora.calculadoras.Add(new Cubo());
            miCalculadora.calculadoras.Add(new Cuadrado());

            Console.WriteLine("Ingresa cuantos calculos quieres que tu calculadora realice:");
            int calculos = int.Parse(Console.ReadLine());
            for (int i = 0; i < calculos; i++) {
                miCalculadora.Calcular();
            }

            Console.WriteLine($"Resultado final: {miCalculadora.GetNumero()}");
        }
    }
}
