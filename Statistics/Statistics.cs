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
    }
}
