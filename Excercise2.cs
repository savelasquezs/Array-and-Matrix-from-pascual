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


            // la columna que irá cambiando de valor para mostrarse
            int iterationColumn = matriz.GetLength(1) - 1,

            // la fila que irá cambiando de valor para mostrarse
                IterationRow = matriz.GetLength(0) - 1,

                // la fila actual, es el indice mas bajo de la fila a la cual hemos llegado
                currentRow = matriz.GetLength(0) - 1,

                //Es el maximo indice de la columna al cual podemos llegar teniendo en cuenta la posición actual
                maxrow = matriz.GetLength(0) - 1,

                //Es el maximo indice de la fila al cual podemos llegar teniendo en cuenta la posición actual
                maxcol = matriz.GetLength(1) - 1;

            for (int i = matriz.Length; i > 0; i--)
            {
                Console.WriteLine(matriz[IterationRow, iterationColumn]);
                // Si la fila por la cual vamos, es la ultima fila de el array
                // o es la fila mas baja a la cual puedo acceder, empiezo una nueva diagonal

                if (IterationRow == maxrow)
                {
                    // cada vez que termino una diagonal, subo una fila de la fila mas alta que habia alcanzado.

                    currentRow--;
                    //Cuando currentRow ==-1 por primera vez significa que pasamos la diagonal principal
                    //Cuando pasamos de esa diagonal, debemos actualizar nuestros limites porque los datos
                    // a los cuales tenemos acceso son mas limitados
                    if (currentRow == -1)
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

    }
}

