using System;
using System.Collections.Generic;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10] { 0.111, 0.1, 0.5, 1.0, 0.2, 0.3, 5, 7, 0, 1};
            var fd = Statistics.Mode(arr);
            Console.WriteLine(fd);
        }
        
    }
}
