using System;
namespace laboratorio5
{
    public class Cubo : ICalcular
    {
        public int Calcular(int numero)
        {
            // En MAX voy a guardar el int más grande tal que elevado al cubo siga estando
            // en el rango válido de las variables de tipo int
            // La ecuación es: MAX * MAX * MAX <= int.MaxValue, al despejar...
            int MAX = Convert.ToInt32(Math.Pow(int.MaxValue, 1.0 / 3.0)) - 1;

            // Ahora hago esta comparación porque el cubo de un número negativo es
            // negativo, y no quiero hacer un número máx pequeo que el int más chico...
            if (numero >= 0) {
                numero = Math.Min(MAX, numero);
            } else {
                numero = Math.Max(-MAX, numero);
            }

            return numero * numero * numero;
        }

        public string GetNombre()
        {
            return "Elevar al cubo";
        }
    }
}
