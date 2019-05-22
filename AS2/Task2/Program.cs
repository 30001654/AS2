using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Algorithm.displayArray());
            int input = getInput();
            Console.WriteLine($"The {input} max numbers are {findMaximum(Algorithm.getNumbers(), input)}");
            Console.ReadLine();
        }

        public static int getInput()
        {
            int input1;
            Console.WriteLine("Enter the number of maximum values you want to find.");
            input1 = int.Parse(Console.ReadLine());
            return input1;
        }

        public static string findMaximum(int[] Numbers, int input1)
        {

            ArrayList Numbers2 = new ArrayList();
            Numbers2 = arrayList(Numbers, Numbers2);
            string maxNums = "";
            for (int i = 0; i < input1; i++)
            {
                int max = 0;
                int index = 0;
                for (int j = 0; j < Numbers2.Count; j++)
                {
                    if ((int)Numbers2[j] > max)
                    {
                        max = (int)Numbers2[j];
                        index = j;
                    }
                }
                maxNums += max + " ";
                Numbers2.RemoveAt(index);
            }
            return maxNums;
        }

        public static ArrayList arrayList(int[] Numbers, ArrayList Numbers2)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers2.Add(Numbers[i]);
            }
            return Numbers2;
        }


    }
}
