using System.Security.Cryptography.X509Certificates;

using System;
namespace ExercieDataStructures
{
    class Exercise3
    {
        private static int[,] _matrix = {
            { 1,  2,  3,  10, 11, 13,},
            { 4,  5,  6,  12, 13, 13, },
            { 7,  8,  9,  14, 15, 13,},
            { 16, 17, 18, 19, 20, 13,},
            { 21, 22, 23, 24, 25, 13,},
            { 26, 27, 28, 29, 13, 13,},

        };

        private static int _initialRowIndex = _matrix.GetLength(0) / 2;
        private static int _initialColumnIndex = _matrix.GetLength(1) / 2;
        private static int _currentRow, _currentColumn;
        private static int _maxCol, _minCol, _maxRow, _minRow;

        public static void Solve()
        {
            Utils.clearWindow();
            Console.WriteLine($@"
            This program aims to traverse a matrix and print the data in a spiral manner
            Starting from the center towards the outside:
            ");

            _currentRow = _initialRowIndex;
            _currentColumn = _initialColumnIndex;
            // Print the center element
            Console.WriteLine(_matrix[_currentRow, _currentColumn]);

            // Define the limits of the first spiral
            _maxCol = _initialColumnIndex + 1;
            _minCol = _initialColumnIndex - 1;
            _maxRow = _initialRowIndex + 1;
            _minRow = _initialRowIndex - 1;

            while (_currentColumn != 0 && _currentRow != _matrix.GetLength(0) - 1)
            {
                MoveLeft(_minCol);
                MoveUp(_minRow);
                MoveRight(_maxCol);
                MoveDown(_maxRow);
                MoveLeft(_minCol);
                // Increase the limits for the next spiral
                _maxCol++;
                _minCol--;
                _maxRow++;
                _minRow--;
            }

            if (_matrix.GetLength(0) % 2 == 0)
            {
                _maxCol--;
                MoveLeft(_minCol);
                MoveUp(_minRow);
                MoveRight(_maxCol);
            }
        }

        private static string MatrixToString(int[,] matrix)
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

        private static void MoveLeft(int edgeIndex)
        {
            while (_currentColumn != edgeIndex)
            {
                _currentColumn -= 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }

        private static void MoveDown(int edgeIndex)
        {
            while (_currentRow != edgeIndex)
            {
                _currentRow += 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }

        private static void MoveRight(int edgeIndex)
        {
            while (_currentColumn != edgeIndex)
            {
                _currentColumn += 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }

        private static void MoveUp(int edgeIndex)
        {
            while (_currentRow != edgeIndex)
            {
                _currentRow -= 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }
    }
}


