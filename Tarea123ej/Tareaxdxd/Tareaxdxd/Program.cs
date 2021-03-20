using System;
using System.Threading;

namespace ejerciciosxdxd
{
    class Program
    {

        public static string Mid(string parametro, int startindex, int length)
        {
            string result = parametro.Substring(startindex, length); //SEPARA CARACTERES DE LA CADENA.
            return result;

        }

        static void Main(string[] args)
        {

            
            string nombre_Cadena; //SE GUARDA LA CADENA DE TEXTO NOMBRE.
            string caracter_Cadena;
            int k = 0; //K, CENTINELA-SIRVE PARA RECORRER COLUMNAS.
            int P = 0; //P, CENTINELA-SIRVE PARA IR RECORRIENDO CARACTERES DE LA CADENA. 
            int longitud_Cadena = 0;
            int cant_Recorrido = 0;

            Console.WriteLine("Ingrese su nombre: ");
            nombre_Cadena = Console.ReadLine();

            Console.SetCursorPosition(1, 12);
            Console.Write(nombre_Cadena); //imprime nombre en pantalla, cursor en columna 1, fila 12.

            longitud_Cadena = nombre_Cadena.Length; //DETERMINA LA CANTIDAD DE CARACTERES QUE TIENE LA CADENA DE TEXTO.
            cant_Recorrido = 25; //DETERMINA CUANTOS ESPACIOS RECORRE LA LETRA POR LA CONSOLA.


            nombre_Cadena = nombre_Cadena.ToUpper(); //CONVIERTE A MAYUSCULAS

            for (P = nombre_Cadena.Length; P >= 1; P--)
            {
                caracter_Cadena = Mid(nombre_Cadena, P - 1, 1); // FUNCION QUE ALMACENA CARACTER POR CARACTER. HASTA P-1
                for (k = longitud_Cadena; k <= cant_Recorrido; k++) //K IRA RECORRIENDO COLUMNA POR COLUMNA. SIEMPRE EN LA FILA 12. HASTA QUE K = 25.
                {
                    Console.SetCursorPosition(k, 12);
                    Console.Write(" " + caracter_Cadena);
                    //Thread.Sleep(25); // PARA QUE SE REPITA CICLO PASAN 25 MILISEGUNDOS.
                }
                cant_Recorrido = cant_Recorrido - 1; //SE VA RESTANDO UN ESPACIO POR CADA CARACTER, SINO TODOS TERMINAN EN EL MISMO LUGAR.
                longitud_Cadena = longitud_Cadena - 1;

            }

            Console.ReadKey();
        }
    }
}