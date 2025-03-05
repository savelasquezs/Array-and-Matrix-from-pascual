using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static int[] numbers = [-5, 4, 8, 9, 10, 12, 17, -5];

    static void Main()
    {
        printMatrix();

        int initialIndex = validarNumero();
        Console.WriteLine("Ingrese 1 para imprimir los numeros de izquierda a derecha");
        Console.WriteLine("Ingrese 2 para imprimir los numeros de derecha a izquierda");
        int option = validateOption();
        if (option == 1)
        {
            for (int i = initialIndex; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
              

                if (i == (numbers.Length-1))
                {
                    for (int j = 0; j < initialIndex; j++)
                    {
                        Console.WriteLine(numbers[j]);
                    }
                }
            }
        }
        else
        {

            for (int i = initialIndex; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
                if (i == 0)
                {
                    for (int j = 7; j > initialIndex; j--)
                    {
                        Console.WriteLine(numbers[j]);
                    }
                }
            }




        }

        static int validarNumero()
        {


            int numero = 0;
            bool esNumero = false;
            while (!esNumero || numero < 0 || numero > numbers.Length - 1)
            {
                Console.WriteLine("Ingrese un número: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
                if (!esNumero)
                {
                    Console.WriteLine("El valor ingresado no es un número o el indice no es valido.");
                }
            }
            return numero;

        }

        static int validateOption()
        {
            int opcion = 0;
            bool esNumero = false;
            while (!esNumero || (opcion != 1 && opcion != 2))
            {
              
                Console.WriteLine("Ingrese un número: ");
                esNumero = int.TryParse(Console.ReadLine(), out opcion);
                if (!esNumero)
                {
                    Console.WriteLine("El valor ingresado no es valido, intente de nuevo");
                }
            }
            return opcion;
        }

        static void printMatrix()
        {
            int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Recorremos las diagonales desde la última columna hacia la primera fila
            for (int inicioFila = filas - 1, inicioColumna = columnas - 1; inicioColumna >= 0; inicioColumna--)
            {
                int i = inicioFila, j = inicioColumna;
                while (i >= 0 && j < columnas)
                {
                    Console.Write(matriz[i, j] + " ");
                    i--;
                    j++;
                }
                Console.WriteLine();
            }

            // Recorremos las diagonales desde la última fila (sin repetir la última columna)
            for (int inicioFila = filas - 2, inicioColumna = 0; inicioFila >= 0; inicioFila--)
            {
                int i = inicioFila, j = inicioColumna;
                while (i >= 0 && j < columnas)
                {
                    Console.Write(matriz[i, j] + " ");
                    i--;
                    j++;
                }
                Console.WriteLine();
            }


        }



    }
}