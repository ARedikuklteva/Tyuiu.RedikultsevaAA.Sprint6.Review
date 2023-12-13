using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RedikultsevaAA.Sprint6.Review.V1.Lib
{
    public class DataService
    {
        public int[,] RndMatrix(int N, int M, int n1, int n2)
        {
            int[,] mtrx = new int[N, M];

            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mtrx[i, j] = rnd.Next(n1, n2);
                }
            }

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            int temp;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        if (mtrx[i, j] >= mtrx[i, k]) continue;
                        temp = mtrx[i, j];
                        mtrx[i, j] = mtrx[i, k];
                        mtrx[i, k] = temp;
                    }

                }
            }

            return mtrx;
        }

        public int Result(int[,] mtrx, int K, int L, int C)
        {
            int rows = mtrx.GetUpperBound(0) + 1;

            int sum = 0;

            for (int i = K; i <= L; i++)
            {
                sum += mtrx[i, C];
            }

            return sum;
        }
    }
}
