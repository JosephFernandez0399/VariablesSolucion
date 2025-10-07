using System;
using System.ComponentModel;

namespace Variables
{
    // =========================================================
    // 1. DEFINICIONES DE STRUCTS (Tipos de Valor)
    // =========================================================
    struct RGBColor
    {
        public int R;
        public int G;
        public int B;
    }

    struct CellPhone
    {
        public bool Memory;
    }

    // =========================================================
    // 2. DEFINICIÓN DE CLASE AUXILIAR: PERSONA
    // =========================================================
    class Persona
    {
        public string nombre;
        public static bool estado = false;

        public void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {nombre}.");
        }

        public static void ejemploStatic()
        {
            Console.WriteLine("Este es un método estático. No necesita una instancia de la clase para ser llamado.");
        }
    }

    // =========================================================
    // 3. DEFINICIÓN DEL NAMESPACE AUXILIAR: VARIABLES.MATH
    // =========================================================
    namespace Math
    {
        public static class Calculadora
        {
            public static int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }
    
    using calculadora = Math.Calculadora; 

    // =========================================================
    // 4. CLASE PRINCIPAL DEL PROGRAMA (PROGRAM.CS)
    // =========================================================
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- INICIO DEL PROGRAMA DE PRÁCTICA ---");

            // --- Uso de Structs ---
            RGBColor color1;
            color1.R = 255;
            CellPhone Motorola;
            Motorola.Memory = false;

            // --- Uso de Clases (Persona) ---
            Persona User1 = new Persona();
            Persona User2 = new Persona();
            User1.nombre = "Joseph";
            User1.Presentarse();
            User2.nombre = "Ana";
            User2.Presentarse();

            Persona.estado = true;
            Console.WriteLine(Persona.estado);
            Persona.ejemploStatic();

            // --- Uso de Clase Estática (Calculadora) ---
            int resultado = calculadora.Sum(34, 50);
            Console.WriteLine("El resultado de la suma es: " + resultado);

            // --- Tipo de datos ---
            byte numero = 10;
            int contador = 33;
            float altura = 1.78f;
            char letra = 'A';
            bool estoFunciona = false;
            string palabra = "Hola";

            Console.WriteLine("Mi numero es: {0} y mi contador es {1}", numero, contador);
            Console.WriteLine(numero);
            Console.WriteLine(contador);
            Console.WriteLine(altura);
            Console.WriteLine(letra);
            Console.WriteLine(estoFunciona);
            Console.WriteLine(palabra);
            Console.WriteLine();

            // --- Conversión de datos ---
            int d = 1;
            byte e = (byte)d;
            float f = 10.50f;
            int o = (int)f;

            String m = "50";
            int n = Convert.ToInt32(m);
            int p = int.Parse(m);
            Console.WriteLine(n + " " + p);

            float t = Convert.ToSingle(m);
            Console.WriteLine(t);

            String nmLetra = "Mario 50";
            try
            {
                int numero1 = Convert.ToInt32(nmLetra);
                Console.WriteLine("fin de la app ");
            }
            catch (Exception)
            {
                Console.WriteLine("No puedo convertir esta variable porque está en un formato diferente (Try-Catch).");
            }

            // --- Operadores ---
            int num1 = 5, num2 = 5, num3 = 10;
            Console.WriteLine($"Suma de operadores: {num1 + num2 + num3}");

            int D = 6, F = 12;
            Console.WriteLine($"D == F? {D == F}");

            // --- Arrays ---
            int[] numbers = new int[3];
            numbers[0] = 1; numbers[1] = 2; numbers[2] = 3;

            Console.WriteLine("Array 'numbers' elementos:");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            int[] numerosEdificios = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array 'numerosEdificios' elementos:");
            for (int i = 0; i < numerosEdificios.Length; i++)
                Console.WriteLine(numerosEdificios[i]);

            bool[] estados = new bool[3];
            estados[0] = true;
            Console.WriteLine("Array 'estados' elementos:");
            for (int i = 0; i < estados.Length; i++)
                Console.WriteLine(estados[i]);

            String[] nombreArray = new string[3] { "l", "j", "p" };
            Console.WriteLine("Array 'nombreArray' elementos:");
            for (int i = 0; i < nombreArray.Length; i++)
                Console.WriteLine(nombreArray[i]);

            // --- String Manipulation ---
            String nombre = "Joseph";
            String apellido = "Henry";

            String nombreCompleto = nombre + " " + apellido;
            Console.WriteLine($"Concatenación: {nombreCompleto}");

            string nombreFormato = String.Format("{0} {1}", nombre, apellido);
            Console.WriteLine($"String.Format: {nombreFormato}");

            int[] Number = new int[5] { 1, 2, 3, 4, 5 };
            String listNumber = String.Join(",", Number);
            Console.WriteLine($"String.Join: {listNumber}");

            Console.WriteLine("Resultado de \"Hola\\nMundo\":");
            Console.WriteLine("Hola\nMundojoseph");

            // --- AQUÍ ESTÁ TU IMPRESIÓN CORREGIDA ---
            String[] nombres = new string[3] { "Mario", "Juan", "Pedro" };
            string listaNombres = String.Join(",", nombres);
            Console.WriteLine(listaNombres);

            Console.WriteLine("--- FIN DEL PROGRAMA DE PRÁCTICA ---");

            Console.ReadKey(); // Pausa final
        }
    }
}
