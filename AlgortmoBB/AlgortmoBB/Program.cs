using System;

namespace AlgortmoBB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 5, 6, 7, 20, 30, 31, 32, 50, 51 };
            int x = BusquedaBinaria(arr, 32);
        }


        public static int BusquedaBinaria(int[] arr, int x)
        {
            if (arr.Length > 1)
            {
                while (true)
                {
                    int pivote = arr.Length / 2;
                    if (arr[pivote] == x)
                    {
                        return pivote;
                    }
                    if (arr[pivote] > x)
                    {
                        int[] arrAux = new int[pivote];
                        for (int i = 0; i < arrAux.Length; i++)
                        {
                            arrAux[i] = arr[i];
                        }
                        arr = arrAux;
                    }
                    else
                    {
                        int[] arrAux = new int[pivote + 1];
                        for (int i = 0; i < arrAux.Length; i++)
                        {
                            arrAux[i] = arr[i + pivote];
                        }
                        arr = arrAux;
                    }
                }
            }
            else
            {
                if (arr.Length == 1)
                {
                    if (arr[0] == x)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
