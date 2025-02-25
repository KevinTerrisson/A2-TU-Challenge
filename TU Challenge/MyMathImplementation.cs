﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a,int b)
        {
            return a + b;

        }

        public static bool IsMajeur(int age)
        {
            if (age >= 0 && age < 145)
            {
                if(age >= 18)
                {
                    return true;
                }
                return false;
            }
            throw new ArgumentException();
        }

        public static bool IsPrimary(int a)
        {
            int b = 1;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    b++;
                }
            }

            return b < 3;
        }


        public static object GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    list.Add(i);
                }
            }

            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            return a % b == 0 ? true : false;
        }

        public static bool IsEven(int a)
        {
           return a % 2 == 0 ? true : false;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a == b)
                return 0;
            return (b - a) / Math.Abs(a - b);
            
        }

        public static bool IsListInOrder(List<int> list)
        {
            if (list.Count < 2)
            {
                return true;
            }

            for( int i =0; i < list.Count - 1; i++)
            {
                int result = IsInOrder(list[i], list[i + 1]);
                if (result < 0)
                    return false;
            }

            return true;
        }

        public static int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public static int Power2(int a)
        {
            return a*a;
        }

        public static List<int> Sort(List<int> list)
        {
            for(int i = 1; i <list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (list[i] < list[j] && i > j)
                    {
                        int temp = list[i];
                        for (int k = i; k> j; k--)
                        {
                            list[k] = list[k-1];
                        }
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
