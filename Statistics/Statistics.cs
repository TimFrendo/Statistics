using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    static class Statistics
    {
        public static double Mode(double[] arr)
        {
            Dictionary<double, int> frequency = new Dictionary<double, int>();
            double mode = 0.0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!frequency.ContainsKey(arr[i]))
                    frequency.Add(arr[i], 1);
                else
                    frequency[arr[i]] += 1;
            }
            foreach (var freq in frequency)
            {
                if (temp < freq.Value)
                {
                    temp = freq.Value;
                    mode = freq.Key;
                }
            }
            return mode;
        }

        public static double Mediana(double[] arr)
        {
            double mediana;

            if (arr.Length % 2 == 0)
            {
                mediana = (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2;
            }
            else
            {
                mediana = arr[arr.Length / 2];
            }
            return mediana;
        }
        
        public static double Mean(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }

        public static double Maximum(double[] arr)
        {
            double maximum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (maximum < arr[i])
                {
                    maximum = arr[i];
                }
            }

            return maximum;
        }

        public static double Minimum(double[] arr)
        {
            double minimum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (minimum > arr[i])
                {
                    minimum= arr[i];
                }
            }

            return minimum;
        }

        public static double Span(double[] arr)
        {
            return Maximum(arr) - Minimum(arr);
        }
    }
}
