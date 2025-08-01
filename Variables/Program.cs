using System;
using System.ComponentModel;
using Variables.Math;

namespace Variables
{

    struct RGBColor
    {
        public int R;
        public int G;
        public int B;
    }

    struct cellPhone
    {
        public bool Memori;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Struct

            RGBColor color1;
            color1.R = 255;
            cellPhone Motorola;
            Motorola.Memori = false;


            //Clases

            Persona User1 = new Persona();
            Persona User2 = new Persona();
            User1.nombre = "Joseph";
            User1.Presentarse();
            User2.nombre = "Ana";
            User2.Presentarse();

           
            // we declare a class with the name "Persona" and then we chenge the value  for true
            Persona.estado = true;
            Console.WriteLine(Persona.estado);
            Persona.ejemploStatic();
            //Calculadora

            int resultado = calculadora.Sum(34, 50);
            Console.WriteLine("el resultado de la suma es: " + resultado);



            // Tipo de datos
            byte numero = 10;
            int contador = 33;
            float altura = 1.78f;
            char letra = 'A';
            bool estoFunciona = false;
            string palabra = "Hola";

            // String format
            Console.WriteLine("Mi numero es: {0} y mi contador es {1}",numero, contador);

            Console.WriteLine(numero);
            Console.WriteLine(contador);
            Console.WriteLine(altura);
            Console.WriteLine(letra);
            Console.WriteLine(estoFunciona);
            Console.WriteLine(palabra);
            Console.ReadKey();

            // CONVERCION DE DATOS
            // Convercion implicita
            int d = 1;
            byte e = (byte)d;

            float f = 10.50f;
            int o = (int)f;

            Console.WriteLine();

            // Conversaciones de datos NO COMPATIBLES
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

                Console.WriteLine("I can´t convert this variable becouse is a diferent format ");
            }

            // Operadores 
            int num1 = 5;
            int num2 = 5;
            int num3 = 10;

            Console.WriteLine(num1 + num2 + num3);

            /*   
             *----------- Comparacion ----------*
             *
             * Es igual             == 
             * no es igual          !=
             * Mayor                >
             * Menor                <
             * Menor o igual        <=
             * Mayor o igual        >=
             * 
             */

            int D = 6;
            int F = 12;

            Console.WriteLine(D == F);



            // -------------- Tipos no primitivos / Tipos Referencia --------------------

            /*
             * Clases
             * Struct
             * Arrays
             * String
             * Enum
             * 
             * 
             
             */


            /* -------- Array -----------
             * 
             * is a structure of data that function 
             * for store data collections in the same time
             */

            // Variable declaration 
            int[] numbers = new int[3]; // Array size in this case is 3 but you can put wherever you want 

            // Access elements 

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);



        }
    }
}
A<