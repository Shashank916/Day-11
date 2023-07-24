using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for Bubble Sort");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Numbers are :");
            Print(num);

            Console.WriteLine("Array without Sort");
            Print(num);
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            BubbleSort(num);
            s1.Stop();
            Console.WriteLine("Array after bubble sort");
            Print(num);
            Console.WriteLine($"Arraysize is {num.Length} Time Taken for bubble sort {s1.Elapsed.TotalMilliseconds} milliseconds");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter numbers for insertion sort");
            int[] num1 = new int[5];
            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Numbers are :");
            Print(num1);
            Console.WriteLine("Array without Sort");
            Print(num1);
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            InsertionSort(num1);
            s2.Stop();
            Console.WriteLine(" Array after Insertion sort");
            Print(num1);
            Console.WriteLine($"Arraysize is {num1.Length} Time Taken for insertion sort {s2.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment14
//{
//    internal class Program
//    {
//        public static void BubbleSort(int[] bubbles)
//        {
//            for (int i = 0; i < bubbles.Length; i++)
//            {
//                for (int j = i + 1; j < bubbles.Length; j++)
//                {
//                    if (bubbles[i] > bubbles[j])
//                    {
//                        int temp = bubbles[i];
//                        bubbles[i] = bubbles[j];
//                        bubbles[j] = temp;
//                    }
//                }
//            }
//        }
//        public static void SelectionSort(int[] bubbles)
//        {
//            for (int i = 0; i < bubbles.Length; i++)
//            {
//                int min = i;
//                for (int j = i; j < bubbles.Length; j++)
//                {
//                    if (bubbles[min] > bubbles[j])
//                        min = j;
//                }
//                int temp = bubbles[i];
//                bubbles[i] = bubbles[min];
//                bubbles[min] = temp;
//            }
//        }
//        public static void Generator(int[] bubbles)
//        {
//            Random rand = new Random();
//            for (int i = 0; i < bubbles.Length; i++)
//            {
//                bubbles[i] = rand.Next(1000);
//            }
//        }
//        public static void Print(int[] bubbles)
//        {
//            for (int i = 0; i < bubbles.Length; i++)
//                Console.Write(bubbles[i] + " ");
//            Console.WriteLine();
//        }
//        public static bool Verification(int[] bubbles)
//        {
//            for (int i = 0; i < bubbles.Length - 1; i++)
//            {
//                if (bubbles[i] > bubbles[i + 1])
//                    return false;
//            }
//            return true;
//        }
//        public static void TimeMeasure(int[] bubbles)
//        {
//            Stopwatch watch = new Stopwatch();
//            Generator(bubbles);
//            watch.Start();
//            BubbleSort(bubbles);
//            watch.Stop();
//            Console.WriteLine("Is the Array Sorted Correctly???");
//            Console.WriteLine("   " + Verification(bubbles));
//            if (Verification(bubbles))
//                Console.WriteLine($"Time Taken to sort the Array of {bubbles.Length} is {watch.Elapsed.TotalMilliseconds} milliSeconds");
//            Console.WriteLine("The Elements in the array :");
//            Print(bubbles)
//            Console.WriteLine();
//        }
//        public static void Compare()
//        {
//            int[] bubble1 = new int[50];
//            int[] bubble2 = new int[50];
//            double time1 = CompareBubble(bubble1);
//            double time2 = CompareSelection(bubble2);
//            if (time1 > time2)
//                Console.WriteLine($"Selection Sort Time {time2} is Faster than Bubble Sort Time {time1}");
//            else
//                Console.WriteLine($"Bubble Sort Time {time1} is Faster than Selection Sort Time {time2}");
//        }
//        public static double CompareBubble(int[] bubble)
//        {
//            Stopwatch watch = new Stopwatch();
//            Generator(bubble);
//            watch.Start();
//            BubbleSort(bubble);
//            watch.Stop();
//            return watch.Elapsed.TotalMilliseconds;
//        }
//        public static double CompareSelection(int[] bubble)
//        {
//            Stopwatch watch = new Stopwatch();
//            Generator(bubble);
//            watch.Start();
//            BubbleSort(bubble);
//            watch.Stop();
//            return watch.Elapsed.TotalMilliseconds;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Array Size of 100");
//            int[] bubble1 = new int[100];
//            TimeMeasure(bubble1);
//            Console.WriteLine("Array Size of 500");
//            int[] bubble2 = new int[500];
//            TimeMeasure(bubble2);
//            Console.WriteLine("Array Size of 5000");
//            int[] bubble3 = new int[5000];
//            TimeMeasure(bubble3);
//            Console.WriteLine("Array Size of 10000");
//            int[] bubble4 = new int[10000];
//            TimeMeasure(bubble4);
//            Console.WriteLine("Comparison Between 2 Sorts");
//            Compare();
//            Console.ReadKey();
//        }
//    }
//}