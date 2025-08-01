using System;

namespace Variables
{
    public class Persona
    {
        public string nombre;
        public static bool estado = false;
        public void Presentarse()
        {
            Console.WriteLine("Hola mi nombre es: " + nombre);
        }

        public static void ejemploStatic()
        {
            Console.WriteLine("Ejemplo Static");
        }

    }
}
