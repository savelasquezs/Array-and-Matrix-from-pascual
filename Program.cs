using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ExercieDataStructures
{

    class Program
    {


        static void Main()
        {

            System.Console.WriteLine(@"
            Bienvenido a ejercicios de estructura de datos: arrays y matrices
            El equipo está conformado por:
             - Santiago Velásquez Serna //1038414022



            ");
            ShowMainMenu();
        }

        static private void AskToContinue()
        {
            Console.WriteLine("Desea ver otro ejercicio? (S/N)");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "S")
            {
                ShowMainMenu();
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        static private void ShowMainMenu()
        {


            System.Console.WriteLine(@"
            Ingrese:
            1. Impresión de array en orden definido por el usuario
            2. Impresión de elementos de matriz en diagonal inversa");
            int[] menuOptions = [1, 2];
            int option = Utils.validateNumericalOption(menuOptions);
            if (option == 1)
            {
                Exercise1.Solve();
                AskToContinue();
            }
            else
            {
                Exercise2.Solve();
                AskToContinue();
            }
        }
    }
}