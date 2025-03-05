namespace ExercieDataStructures
{

    class Exercise1
    {
        static int[] numbers = [-5, 4, 8, 9, 10, 12, 17, -5];
        static string numbersStr = string.Join(" // ", numbers);
        public static void Solve()
        {
            Utils.clearWindow();
            Console.WriteLine($@"
            Este programa pretende hacer un recorrido de un array 
            empezando desde el indice indicado por usted y en el orden que usted elija que puede ser 
            de derecha a izquierda o izquierda a derecha
            

            ");

            Console.WriteLine("Ingrese el indice de el elemento desde el cual desea empezar el recorrido: ");
            int initialIndex = Utils.indexOfIterable(numbers);

            Console.WriteLine($@"
            Perfecto ha ingresado el indice {initialIndex} que corresponde al numero {numbers[initialIndex]}
            Ahora ingrese por favor:
            1. Imprimir los numeros de izquierda a derecha
            2. Imprimir los numeros de derecha a izquierda 

            
            ");


            int[] options = [1, 2];

            int option = Utils.validateNumericalOption(options);
            if (option == 1)
            {
                System.Console.WriteLine($@"
                La opción ingresada es {option}
                Imprimiremos los numeros de izquierda a derecha
                recuerda que el array original es:
                {numbersStr}

                ");
                for (int i = initialIndex; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);


                    if (i == (numbers.Length - 1))
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
                System.Console.WriteLine($@"
                La opción ingresada es {option}
                Imprimiremos los numeros de derecha a izquierda
                Recuerda que el array original es:
                {numbersStr}

                ");

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



        }


    }
}

