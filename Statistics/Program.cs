using System;
using System.Collections.Generic;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[13] {-2,  -1, 0, 1, -2, 3.2, 1.9, 1.9, 6.1, 1.9, 3.8, 7.9, 0 };
            Console.WriteLine($"length of array: {arr.Length}");
            var mode = Statistics.Mode(arr);
            Console.WriteLine($"mode of array: {mode}");
            var mediana = Statistics.Mediana(arr);
            Console.WriteLine($"mediana of array: {mediana}");
            var mean= Statistics.Mean(arr);
            Console.WriteLine($"mean of array: {mean}");
            var maximum = Statistics.Maximum(arr);
            Console.WriteLine($"maximum of array: {maximum}");
            var minimum = Statistics.Minimum(arr);
            Console.WriteLine($"minimum of array: {minimum}");
            var span = Statistics.Span(arr);
            Console.WriteLine($"span of array: {span}");
        }
        
    }
}
