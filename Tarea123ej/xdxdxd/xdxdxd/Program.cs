using System;
using System.Threading;

namespace xdxdxd
{
    class Program
    {
        public static void dibuja(int cantidad)
        {
            int FF = 55;//crea el tamaño de las columnas, osea que pondra 19 veces el valor X de forma vertical
            int CF = 77;// crea el tamaño de las filas , osea que pondra 19 veces el valor? de forma horizontal
            int FI = 2;//sirve para dar esapacios entre filas 
            int CI = 2; //sirve para dar espacios en colunma
            int F, C, A;//variables que serviran de centinelas para guardar valores de otras variables
            for (A = 1; A <= cantidad; A++)//asinga, tomal el valor de cantidad y se ira aumentando 
            {
                for (F = CI; F <= CF; F++) //asinga, tomal el valor de cantidad y se ira aumentando 
                {
                    Console.SetCursorPosition(F, FF); Console.Write("?");//toma las coordenadas de las variable x y columnas, y va a dar espacios conforme a las coordenadas y luego imprime
                    Console.SetCursorPosition(F, FI); Console.Write("?");//Aqui igual
                }
                for (C = FI; C <= FF; C++)
                {
                    Console.SetCursorPosition(CI, C); Console.Write("X");//Aqui igual
                    Console.SetCursorPosition(CF, C); Console.Write("X");//Aqui igual
                }
                FI = FI + 1;//se igual la misma variable y se le ira sumando un valor
                FF = FF - 1;//se igual la misma variable y se le ira sumando un valor
                CI++;//a la variable se le suma el valor de 1
                CF++;//a la variable se le suma el valor de 1
            }
        }
        static void Main(string[] args)
        {
            for (int tam = 1; tam < 25; tam++)//asinga el valor 1  y se ira aumentando hasta que llegue a ese valor que es 24
            {
                dibuja(tam);//imprime la funcion pulic que se llama dibuja 
                Thread.Sleep(100000);//pausa 300 milesengundos
            }
        }
    }
}
