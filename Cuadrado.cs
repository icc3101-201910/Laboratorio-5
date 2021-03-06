﻿using System;
namespace laboratorio5
{
    public class Cuadrado : ICalcular
    {
        public int Calcular(int numero)
        {
            // La raiz de un número negativo no existe, retorno 0
            if (numero < 0) {
                return 0;
            }

            // En MAX voy a guardar el int más grande tal que elevado al cubo siga estando
            // en el rango válido de las variables de tipo int
            // La ecuación es: MAX * MAX <= int.MaxValue, al despejar...
            int MAX = Convert.ToInt32(Math.Sqrt(int.MaxValue)) - 1; // <-- el -1 para asegurarnos

            numero = Math.Min(MAX, numero);

            return numero * numero;
        }

        public string GetNombre()
        {
            return "Elevar al cuadrado";
        }
    }
}
