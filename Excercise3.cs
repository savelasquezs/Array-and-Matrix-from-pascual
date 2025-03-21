using System.Security.Cryptography.X509Certificates;

using System;
namespace ExercieDataStructures
{
    class Exercise3
    {

        int[,] _matrix;
        int _initialRowIndex,
         _initialColumnIndex,
         _currentRow, _currentColumn,
         _maxCol, _minCol, _maxRow, _minRow;



        public void Solve()
        {
            Utils.clearWindow();
            Console.WriteLine($@"
            This program aims to traverse a matrix and print the data in a spiral manner
            Starting from the center towards the outside:
            ");

            // Ask the user for the quantity of elements in the matrix
            Console.Write("Enter the quantity of elements in the matrix (n*n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Create a random matrix with n*n elements
            _matrix = new int[n, n];
            createMatrix(n);

            // Define the initial position in the matrix
            _initialRowIndex = _matrix.GetLength(0) / 2;
            _initialColumnIndex = _matrix.GetLength(1) / 2;

            // Print the matrix
            Console.WriteLine("Matrix:");
            Console.WriteLine(MatrixToString(_matrix));

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

        private string MatrixToString(int[,] matrix)
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

        private void MoveLeft(int edgeIndex)
        {
            while (_currentColumn != edgeIndex)
            {
                _currentColumn -= 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }

        private void MoveDown(int edgeIndex)
        {
            while (_currentRow != edgeIndex)
            {
                _currentRow += 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }

        private void MoveRight(int edgeIndex)
        {
            while (_currentColumn != edgeIndex)
            {
                _currentColumn += 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }

        private void MoveUp(int edgeIndex)
        {
            while (_currentRow != edgeIndex)
            {
                _currentRow -= 1;
                Console.WriteLine(_matrix[_currentRow, _currentColumn]);
            }
        }

        private void createMatrix(int n)
        {

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _matrix[i, j] = random.Next(1, 101);
                }
            }

        }
    }
}


