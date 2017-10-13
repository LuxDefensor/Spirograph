using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spirograph
{
    public static class Utils
    {
        public static double Degrees2Radians(double angleInDegrees)
        {
            return angleInDegrees * Math.PI / 180;
        }

        public static double Radians2Degrees(double angleInRadians)
        {
            return angleInRadians * 180 / Math.PI;
        }

        public static int CountLoops(int fixedRadius, int movingRadius)
        {
            return LeastCommonMultiple(fixedRadius, movingRadius) / fixedRadius;
        }

        public static int LeastCommonMultiple(int a, int b)
        {
            int[] A = Factorization(a);
            int[] B = Factorization(b);
            int[] result = new int[A.Length + B.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (k < result.Length)
            {
                if (i >= A.Length)
                {
                    if (j >= B.Length)
                        result[k] = 1;
                    else
                    {
                        result[k] = B[j];
                        j++;
                    }
                }
                else
                {
                    if (j >= B.Length)
                    {
                        result[k] = A[i];
                        i++;
                    }
                    else
                    {
                        if (A[i] == B[j])
                        {
                            result[k] = A[i];
                            i++;
                            j++;
                        }
                        else
                        {
                            if (A[i] < B[j])
                            {
                                result[k] = A[i];
                                i++;
                            }
                            else
                            {
                                result[k] = B[j];
                                j++;
                            }
                        }
                    }
                }
                k++;
            }
            return result.Aggregate((x, y) => x * y);
        }

        public static int[] Factorization(int N)
        {
            int X = N;
            List<int> result = new List<int>();
            for (int i = 2; i <= N / 2; i++)
            {
                while (X > 1)
                {
                    if (X / i * i == X)
                    {
                        X = X / i;
                        result.Add(i);
                    }
                    else
                        break;
                }
            }
            return result.ToArray();
        }
    }
}
