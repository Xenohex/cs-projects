using System;
using System.Drawing;

namespace CSharpSandbox
{
    public class Algorithms
    {
        // 1.1

        // Euclid's Algorithm
        public int gcd(int m, int n)
        {
            int r = 0;
            while (n != 0)
            {
                Console.WriteLine(m);
                Console.WriteLine(n + "\n-------");
                r = m % n;
                m = n;
                n = r;
            }
            return m;
        }

        // Locker problem
        /* There are n lockers in a hall numbered sequentially from 1 to n
         * They are all closed to start off
         b* You make n passes by the lockers, each time starting with #1
         * On the ith pass, i = 1, 2, ..., n, you toggle the door of every ith locker
         * (if open, you close it; if closed, you open it)
         * After the last pass (nth pass), which locker doors are open and which are closed?
         * How many are open?
         * 
         * Realistically, n ≥ 1 
         */
        public int lockersOpenFirstIteration(int[] lockers, int n)
        {
            int i = 1;
            int open = 0;
            while (i <= n)
            {
                for (int j = 1; j <= n; j++)
                {
                    printIntArray(lockers);
                    if (j % i == 0)
                    {
                        lockers[j - 1] = toggle(lockers[j - 1]);
                        if (lockers[j - 1] == 1)
                        {
                            open++;
                        }
                        else
                        {
                            open--;
                        }
                    }
                }
                i++;
            }
            printIntArray(lockers);
            printOpen(lockers);
            return open;
        }

        public int lockersOpenSecondIteration(int[] lockers, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    lockers[i - 1] = toggle(lockers[i - 1]);
                }
            }
            printIntArray(lockers);
            printOpen(lockers);
            return (int)Math.Floor(Math.Sqrt(n));
        }

        // 0 equals closed | 1 = open
        public int toggle(int locker)
        {
            if (locker == 0)
            {
                return 1;
            }
            return 0;
        }

        public void printIntArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public void print2DIntArray(int[,] array)
        {
            int d1 = array.GetLength(0);
            int d2 = array.GetLength(1);
            for (int i = 0; i < d2; i++)
            {
                Console.Write("[");
                for (int j = 0; j < d1; j++)
                {
                    Console.Write($" {array[j, i]} ");
                }
                Console.WriteLine("]");
            }
        }

        public void printOpen(int[] lockers)
        {
            int n = lockers.Length;
            for (int i = 1; i <= n; i++)
            {
                if (lockers[i - 1] == 1)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("END");
        }

        // 1.2

        // binary converter
        public long binaryConverter(int n)
        {
            long result = 0;
            int bit = 1;

            while (bit <= n)
            {
                bit *= 2;
            }

            while (n != 0)
            {
                if (n - bit >= 0)
                {
                    n -= bit;
                    result += 1;
                }
                result *= 10;
                bit /= 2;
            };
            return result / 10;
        }

        //Min distance calculator
        public int MinimumDistance(int[] A)
        {
            int n = A.Length;
            int dmin = 9999;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; j++)
                {
                    if (i != j && Math.Abs(A[i] - A[j]) < dmin)
                    {
                        dmin = Math.Abs(A[i] - A[j]);
                    }
                }
            }
            return dmin;
        }

        // 1.3

        // sorting problem
        public int[] ComparisonCountingSort(int[] A)
        {
            int n = A.Length;
            int[] S = new int[n];
            int[] Count = new int[n];
            for (int i = 0; i < n; i++)
            {
                Count[i] = 0;
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] < A[j])
                    {
                        Count[j] = Count[j] + 1;
                    }
                    else
                    {
                        Count[i] = Count[i] + 1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                S[Count[i]] = A[i];
            }
            return S;
        }

        //2.3

        // summation calculator
        public int sumOdds(int n, int stop)
        {
            int result = 0;
            while (n <= stop)
            {
                result += n;
                n += 2;
            }
            return result;
        }

        public int sumCustom(int n, int i)
        {
            int result = 0;
            while (i <= n)
            {

                i++;
            }
            return result;
        }

        public int sumOfCubes(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return sumOfCubes(n - 1) + (n * n * n);
            }
        }

        // Unique Elements
        public bool UniqueElements(int[] A)
        {
            int n = A.Length;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (A[i] == A[j]) return false;
                }
            }
            return true;
        }

        // GE matrix thing
        // Input, an n * (n+1) matrix A[0..n - 1, 0..n] of real numbers
        public int[,] GE(int[,] A)
        {
            int n = A.Length;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; i < n - 1; j++)
                {
                    for (int k = i; k < n; k++)
                    {
                        A[j,k] = A[j,k] - A[i,k] * A[j,i] / A[i,i];
                    }
                }
            }
            return A;
        }

        // 2.4

        // 2^n calculator
        // Algorithm S(n)
        // Computes 2^n recursively
        // Input: A positive integer n > 1
        // Output: Value of 2^n
        public int twoNthPower(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            else
            {
                int c = 1;
                for (int i = 0; i < n-1; i++)
                {
                    c *= 2;
                }
                return twoNthPower(n-1) * ((c + c) / c);    // C = 2^(n-1)
            }
        }

        // Chapter 3

        /* Ring
         * n = 4
         * [
         *  0, 1, 0, 1,
         *  1, 0, 1, 0, 
         *  0, 1, 0, 1,
         *  1, 0, 1, 0
         * ]
         * n = 5
         * [
         *  0, 1, 0, 0, 1,
         *  1, 0, 1, 0, 0,
         *  0, 1, 0, 1, 0,
         *  0, 0, 1, 0, 1,
         *  1, 0, 0, 1, 0
         *  ]
         * Check if each node only has two true elements
         * 
         * Star
         * n = 4
         * [
         *  0, 1, 1, 1,
         *  1, 0, 0, 0,
         *  1, 0, 0, 0,
         *  1, 0, 0, 0
         * ]
         * Check if only one node is connected to all the others
         * 
         * Fully Connected
         * n = 4
         * [
         *  0, 1, 1, 1, 
         *  1, 0, 1, 1, 
         *  1, 1, 0, 1,
         *  1, 1, 1, 0
         * ]
         * Check if all nodes are connected
         * In an undirected graph, all matrices are symmetric
         */
        // Determine Network Topology of a matrix
        public string networkTopology(bool[,] A)
        {
            int n = (int)Math.Sqrt(A.Length);

            // Check for ring
            bool isRing = true;
            int connectionCount;
            // Check for star
            bool isStar = true;
            int hubIndex = -1;
            // Check for mesh
            bool isMesh = true;

            //Initiate Loop
            for (int i = 0; i < n; i++)
            {
                connectionCount = 0;
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j])
                    {
                        connectionCount++;  // for ring + mesh
                    }
                    
                }
                if (connectionCount != 2)   // for ring
                {
                    isRing = false;
                }
                if (isStar)
                {
                    if (connectionCount == n - 1)
                    {
                        if (hubIndex == -1)
                        {
                            hubIndex = i;
                        }
                        else if (hubIndex != i)
                        {
                            isStar = false;
                        }
                    }
                    else if (connectionCount > 1)
                    {
                        isStar = false;
                    }
                }

                if (connectionCount != n - 1) // for mesh
                {
                    isMesh = false;
                }
            }

            // Finishing up
            if (isRing)
            {
                return "Ring topology";
            }
            else if (isStar)
            {
                return "Star topology";
            }
            else if (isMesh)
            {
                return "Mesh topolgoy";
            }

            return "Unknown topology";

            /*Sample tests
            bool[,] ring =
            {
                { false, true, false, false, true },
                { true, false, true, false, false },
                { false, true, false, true, false },
                { false, false, true, false, true },
                { true, false, false, true, false }
            };
            bool[,] starZero =
            {
                { false, true, true, true },
                { true, false, false, false },
                { true, false, false, false },
                { true, false, false, false }
            };
            bool[,] starOne =
            {
                { true, false, false, false },
                { false, true, true, true },
                { true, false, false, false },
                { true, false, false, false }
            };
            bool[,] mesh =
            {
                { false, true, true, true },
                { true, false, true, true },
                { true, true, false, true },
                { true, true, true, false }
            };
             */
        }

        // 4.1

        public int[] modifiedSelectionSort(int[] array)
        {
            // Sorts an array into filled and unfilled (true or false)
            int temp = 0;
            int n = (int) array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (array[i] == 0)
                {
                    for (int j = n - 1; j >= n / 2; j--)
                    {
                        if (array[j] == 1)
                        {
                            // swap or pour soda
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            return array;
        }

        // mark even number of cells next to each other where they all have an odd # of neighbors
        public int[,] markingCells(int n)
        {
            int length = (n / 2) + 1;
            int[,] array = new int[length, 3];
            for (int i = 1; i <= length; i++)
            {
                array[i - 1, 1] = 1;
                if (i == length)
                {
                    return array;
                }
                if (i % 2 == 0)
                {
                    array[i - 1, 0] = 1;
                }
                else if (i % 2 == 1 && i != 1)
                {
                    array[i - 1, 2] = 1;
                }
            }
            return array;
        }

        public void HeapPerm(int[] a, int size, int n)
        {
            // if size becomes 1 then prints the obtained
            // permutation
            if (size == 1)
                printIntArray(a);

            for (int i = 0; i < size; i++)
            {
                HeapPerm(a, size - 1, n);

                // if size is odd, swap 0th i.e (first) and
                // (size-1)th i.e (last) element
                if (size % 2 == 1)
                {
                    int temp = a[0];
                    a[0] = a[size - 1];
                    a[size - 1] = temp;
                }

                // If size is even, swap ith and
                // (size-1)th i.e (last) element
                else
                {
                    int temp = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = temp;
                }
            }
        }
    }
}

