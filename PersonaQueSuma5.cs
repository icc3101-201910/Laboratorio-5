using System;
namespace laboratorio5
{
    public class PersonaQueSuma5 : ICalcular
    {
        public int Calcular(int numero)
        {
            // En MAX voy a guardar el int más grande tal que al sumarle 5
            // en el rango válido de las variables de tipo int
            // La ecuación es: MAX + 5 <= int.MaxValue, al despejar...
            int MAX = int.MaxValue - 5;

            numero = Math.Min(MAX, numero);

            return numero + 5;
        }

        public string GetNombre()
        {
            return "Sumar 5";
        }
    }
}
