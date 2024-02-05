using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic = "not specific to a particular data type"
            //            add <T> to: classes, methods, fields, etc
            //            allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            displayElemts(intArray);

            Console.ReadKey();
        }

        public static void displayElemts<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.Write(item);
            }
        }
    }
}