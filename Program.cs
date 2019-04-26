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


            while(true)
            {
                Console.WriteLine("Elige una operación (ingresa -1 para finalizar):");
                for (int i = 0; i < miCalculadora.calculadoras.Count; i++) {
                    Console.WriteLine($"[{i}] {miCalculadora.calculadoras[i].GetNombre()}");
                }

                string opcion = Console.ReadLine();
                if (opcion == "-1") {
                    break;
                }

                miCalculadora.Calcular(int.Parse(opcion));
                Console.WriteLine($"Resultado parcial: {miCalculadora.GetNumero()}");
            }

            Console.WriteLine($"Resultado final: {miCalculadora.GetNumero()}");
        }
    }
}
