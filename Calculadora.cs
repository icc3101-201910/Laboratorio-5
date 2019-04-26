using System;
using System.Collections.Generic;

namespace laboratorio5
{
    public class Calculadora
    {
        Random random;
        private int numero;
        public List<ICalcular> calculadoras;

        public Calculadora(int numero)
        {
            this.numero = numero;
            calculadoras = new List<ICalcular>();
            random = new Random(); // para que no se repita el mismo número https://stackoverflow.com/q/767999/2056593
        }

        public int GetNumero()
        {
            return numero;
        }

        public void Calcular()
        {
            var calculadoraAlAzar = calculadoras[random.Next(calculadoras.Count)];
            Console.WriteLine($"{calculadoraAlAzar}({numero})");
            numero = calculadoraAlAzar.Calcular(numero);
        }
    }
}
