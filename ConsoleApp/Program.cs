using System;

namespace ConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayString = { "a", "b", "c", "d", "e", "f" };
            int[] ArrayInt = { 2, 1, 5, 4, 8 };
            double[] ArrayDouble = { 2.1, 3.5, 8.4, 0.1, 5.7 }; 
            decimal[] ArrayDecimal = { 2.1m, 2.2m, 2.3m, 2.4m, 2.5m, 2.6m, 2.7m };
            float[] ArrayFloat = { 6.1f, 6.2f, 6.3f, 6.4f, 6.5f, 5.6f, 6.7f, 6.8f, 6.9f };
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Method Pop:");
            Console.WriteLine("Last String Deleted Element: "+ArrayHelper.Pop(ref ArrayString));
            Console.WriteLine("Last Int Deleted Element: " + ArrayHelper.Pop(ref ArrayInt));
            Console.WriteLine("Last Double Deleted Element: " + ArrayHelper.Pop(ref ArrayDouble));
            Console.WriteLine("Last Decimal Deleted Element: " + ArrayHelper.Pop(ref ArrayDecimal));
            Console.WriteLine("Last Float Deleted Element: " + ArrayHelper.Pop(ref ArrayFloat));
            Console.WriteLine("---------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Method Push:");
            Console.WriteLine(ArrayHelper.Push(ref ArrayString, "g")); Console.WriteLine();
            Console.WriteLine(ArrayHelper.Push(ref ArrayInt, 6)); Console.WriteLine();
            Console.WriteLine(ArrayHelper.Push(ref ArrayDouble, 5.5)); Console.WriteLine();
            Console.WriteLine(ArrayHelper.Push(ref ArrayDecimal, 2.9m)); Console.WriteLine();
            Console.WriteLine(ArrayHelper.Push(ref ArrayFloat, 5.5f)); 
            Console.WriteLine("---------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Method Shift:");
            Console.WriteLine("First String Deleted Element: " + ArrayHelper.Shift(ref ArrayString)); 
            Console.WriteLine("First Int Deleted Element: " + ArrayHelper.Shift(ref ArrayInt));
            Console.WriteLine("First Double Deleted Element: " + ArrayHelper.Shift(ref ArrayDouble));
            Console.WriteLine("First Decimal Deleted Element: " + ArrayHelper.Shift(ref ArrayDecimal));
            Console.WriteLine("First Float Deleted Element: " + ArrayHelper.Shift(ref ArrayFloat));
            Console.WriteLine("---------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Method UnShift:");
            Console.WriteLine(ArrayHelper.UnShift(ref ArrayString, "o")); Console.WriteLine();
            Console.WriteLine(ArrayHelper.UnShift(ref ArrayInt, -1)); Console.WriteLine();
            Console.WriteLine(ArrayHelper.UnShift(ref ArrayDouble, -5.5)); Console.WriteLine();
            Console.WriteLine(ArrayHelper.UnShift(ref ArrayDecimal, -2.9m)); Console.WriteLine();
            Console.WriteLine(ArrayHelper.UnShift(ref ArrayFloat, -5.5f));

        }

    }
    static class ArrayHelper
    {
        //Pop---------------------------------------------------------------------------------------------------------------------------
        public static string Pop(ref string[] Array)
        {
            string t;
            t = Array[(Array.Length) - 1];
            return t;
        }
        public static int Pop(ref int[] Array)
        {
            int t;
            t = Array[(Array.Length) - 1];
            return t;
        }
        public static double Pop(ref double[] Array)
        {
            double t;
            t = Array[(Array.Length) - 1];
            return t;
        }
        public static decimal Pop(ref decimal[] Array)
        {
            decimal t;
            t = Array[(Array.Length) - 1];
            return t;
        }
        public static float Pop(ref float[] Array)
        {
            float t;
            t = Array[(Array.Length) - 1];
            return t;
        }
        //Push--------------------------------------------------------------------------------------------------------------------------

        public static int Push(ref string[] Array, string value)
        {
            string[] newArray = new string[Array.Length + 1];
            for (int i = 0; i < Array.Length; ++i)
            {
                newArray[i] = Array[i];
            }
            newArray[Array.Length] = value;
            Console.Write("ArrayString Elements: ");
            for (int i = 0; i < Array.Length + 1; ++i)
            {
                System.Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Array Length: ");
            return newArray.Length;
        }
        public static int Push(ref int[] Array, int value)
        {
            int[] newArray = new int[Array.Length + 1];
            for (int i = 0; i < Array.Length; ++i)
            {
                newArray[i] = Array[i];
            }
            newArray[Array.Length] = value;
            Console.Write("ArrayInt Elements: ");
            for (int i = 0; i < Array.Length + 1; ++i)
            {
                System.Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Array Length: ");
            return newArray.Length;
        }
        public static int Push(ref double[] Array, double value)
        {
            double[] newArray = new double[Array.Length + 1];
            for (int i = 0; i < Array.Length; ++i)
            {
                newArray[i] = Array[i];
            }
            newArray[Array.Length] = value;
            Console.Write("ArrayDouble Elements: ");
            for (int i = 0; i < Array.Length + 1; ++i)
            {
                System.Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Array Length: ");
            return newArray.Length;
        }
        public static int Push(ref decimal[] Array, decimal value)
        {
            decimal[] newArray = new decimal[Array.Length + 1];
            for (int i = 0; i < Array.Length; ++i)
            {
                newArray[i] = Array[i];
            }
            newArray[Array.Length] = value;
            Console.Write("ArrayDecimal Elements: ");
            for (int i = 0; i < Array.Length + 1; ++i)
            {
                System.Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Array Length: ");
            return newArray.Length;
        }
        public static int Push(ref float[] Array, float value)
        {
            float[] newArray = new float[Array.Length + 1];
            for (int i = 0; i < Array.Length; ++i)
            {
                newArray[i] = Array[i];
            }
            newArray[Array.Length] = value;
            Console.Write("ArrayFloat Elements: ");
            for (int i = 0; i < Array.Length + 1; ++i)
            {
                System.Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Array Length: ");
            return newArray.Length;
        }
        //Shift----------------------------------------------------------------------------------------------------------------------------
        public static string Shift(ref string[] Array)
        {
            string t;
            t = Array[0];
            return t;
        }
        public static int Shift(ref int[] Array)
        {
            int t;
            t = Array[0];
            return t;
        }
        public static double Shift(ref double[] Array)
        {
            double t;
            t = Array[0];
            return t;
        }
        public static decimal Shift(ref decimal[] Array)
        {
            decimal t;
            t = Array[0];
            return t;
        }
        public static float Shift(ref float[] Array)
        {
            float t;
            t = Array[0];
            return t;
        }
        //UnShift--------------------------------------------------------------------------------------------------------------------------
        public static int UnShift(ref string[] Array, string value)
        {
            string[] newArray = new string[Array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i + 1] = Array[i];
            }
            Console.Write("Array String Elements: ");
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            Console.Write("Array Length: ");
            Array = newArray;
            return newArray.Length;
        }
        public static int UnShift(ref int[] Array, int value)
        {
            int[] newArray = new int[Array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i + 1] = Array[i];
            }
            Console.Write("Array Int Elements: ");
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            Console.Write("Array Length: ");
            Array = newArray;
            return newArray.Length;
        }
        public static int UnShift(ref double[] Array, double value)
        {
            double[] newArray = new double[Array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i + 1] = Array[i];
            }
            Console.Write("Array Double Elements: ");
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            Console.Write("Array Length: ");
            Array = newArray;
            return newArray.Length;
        }
        public static int UnShift(ref decimal[] Array, decimal value)
        {
            decimal[] newArray = new decimal[Array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i + 1] = Array[i];
            }
            Console.Write("Array Decimal Elements: ");
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            Console.Write("Array Length: ");
            Array = newArray;
            return newArray.Length;
        }
        public static int UnShift(ref float[] Array, float value)
        {
            float[] newArray = new float[Array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i + 1] = Array[i];
            }
            Console.Write("Array Float Elements: ");
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            Console.Write("Array Length: ");
            Array = newArray;
            return newArray.Length;
        }
    }
}

