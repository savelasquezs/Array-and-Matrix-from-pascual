using System.Security.Cryptography.X509Certificates;

namespace ExercieDataStructures
{

    class Exercise2
    {


        public static void Solve()
        {
            Utils.clearWindow();
            Console.WriteLine($@"
            Este programa pretende hacer un recorrido de una matriz en diagonal
            descendente de derecha a izquierda  Pero 
            empezando por la diagonal inferior, es decir desde la posición [n, n]
            

            ");
            int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            string matrixToString = MatrixToString(matriz);

            Console.WriteLine(@$"Recuerda que esta es nuestra matriz:

              {matrixToString}
                ");


            // *****variables principales****

            // la columna que irá cambiando de valor para mostrarse
            int iterationColumn = matriz.GetLength(1) - 1,

            // la fila que irá cambiando de valor para mostrarse
            IterationRow = matriz.GetLength(0) - 1,

            // *****variables auxiliares****

            //  fila centinela, que se actualiza cada vez que lleguemos al final de una diagonal
            currentRow = matriz.GetLength(0) - 1,

            //maximo indice de la fila en la diagonal actual
            maxrow = matriz.GetLength(0) - 1,

            //maximo indice de la columna en la diagonal actual
            maxcol = matriz.GetLength(1) - 1;

            for (int i = matriz.Length; i > 0; i--)
            {
                Console.WriteLine(matriz[IterationRow, iterationColumn]);


                if (IterationRow == maxrow)
                // esta igualdad se cumple cada vez que llegamos al final de una diagonal
                {
                    // actualizamos el valor de la fila donde inicia nuestra proxima diagonal
                    currentRow--;

                    if (currentRow == -1)
                    //como vamos subiendo de la fila 2 a la fila 0, no hay filas mas arriba de ahí, por lo tanto correjimos.
                    // currentRow == -1  cuando lo pasamos por primera vez, indica que pasamos la diagonal principal
                    // y que ahora vamos a recorrer la parte superior que cada vez tiene menos elementos
                    // y que la ultima fila de la diagnola es menor de la ultima fila de la matriz, por lo tanto , actualizamos 
                    // maxcol y maxrow para que no se salga de los limites de la matriz
                    {

                        currentRow = 0;
                        maxcol--;
                        maxrow--;

                    }
                    // Actualizo nuestras posiciones para la siguiente iteración

                    IterationRow = currentRow;
                    iterationColumn = maxcol;
                }
                else
                {
                    // Si no hemos terminado la diagonal, sigo la diagonal descendente

                    //corro hacia la izquierda
                    iterationColumn--;
                    // y corro hacia abajo
                    IterationRow++;
                }

            }

        }
        static string MatrixToString(int[,] matrix)
        {
            string matrixStr = "\n";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixStr += matrix[i, j] + "-";
                    if (j == matrix.GetLength(1) - 1)
                    {
                        matrixStr += "\n";
                    }

                }
            }
            return matrixStr;

        }

    }
}

