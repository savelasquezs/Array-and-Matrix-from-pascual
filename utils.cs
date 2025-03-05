using System;


namespace ExercieDataStructures
{
    class Utils
    {

        public static void showTitle(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine($"\n {title}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int indexOfIterable(int[] numbers)
        {
            int index = 0;
            do
            {

                if (index < 0 || index >= numbers.Length)
                {
                    Console.Clear();
                    showError($"El indice debe ser un numero entre 0 y {numbers.Length - 1}");
                }
                showError("Ingrese por favor un indice valido del elemento: ");


            } while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= numbers.Length);
            clearWindow();
            return index;

        }

        public static int validateNumericalOption(int[] arrayOfOptions)
        {
            int number;
            Console.WriteLine("Por favor ingrese el numero de su elección");
            while (!int.TryParse(Console.ReadLine(), out number) || number < arrayOfOptions.Min() || number > arrayOfOptions.Max())
            {
                showError("Por favor ingrese una opción valida: ");

            }
            clearWindow();
            return number;
        }

        public static void showError(string message)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine($"\n {message}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void clearWindow()
        {
            Console.Clear();
        }

    }
}