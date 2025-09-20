using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Numerics;
using System;
using System.Collections;

namespace Demo6
{
    #region prob2
    public class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            if (IsNumericType(typeof(T)))
            {
                dynamic min = Min;
                dynamic max = Max;
                return (double)(max - min);
            }
            else
            {
                return -1;
            }
        }
        private static bool IsNumericType(Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return $"[{Min}, {Max}]";
        }
    }
    #endregion

    #region prob5
    public class FixedSizeList<T>
    {
        private T[] _items;
        private int _count;

        public int Count
        {
            get { return _count; }
        }
        public int Capacity { get; }

        public FixedSizeList(int capacity)
        {
            if (capacity < 0)
            {
                    Console.WriteLine("Capacity cannot be negative.");
            }
            Capacity = capacity;
            _items = new T[capacity];
            _count = 0;
        }
         public void Add(T item)
         {
            if (_count >= Capacity)
            {
                    Console.WriteLine("The list is full. Cannot add more elements.");
            }
            _items[_count] = item;
            _count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                Console.WriteLine("Invalid index. The index must be within the bounds of the list.");
            }
            return _items[index];
        }
    }
#endregion

    internal class Program
    {
        #region prob1
        static void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void print()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;
            bubbleSort(arr, n);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        #endregion

        #region prob3
        public static void prob3()
        {

            ArrayList a1 = new ArrayList() { 10, 20, 30, 40, 50 };
            int start = 0;
            int end = a1.Count - 1;
            while (start < end)
            {
                object temp = a1[start];
                a1[start] = a1[end];
                a1[end] = temp;

                start++;
                end--;
            }
        }
        #endregion

        #region prob4
        public void even(List<int> Numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in Numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            foreach (var item in evenNumbers)
            {
                Console.Write(item+", ");
            }
        }
        #endregion


        public static void Main(string[] args)
        {

        }
    }
}

