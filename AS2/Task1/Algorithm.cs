using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Algorithm
    {
        private static int[] Numbers = new int[50];

        private static void genArray()
        {
            Random rand = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rand.Next(1, 100);
            }
        }

        public static string displayArray()
        {
            genArray();
            string display = "";
            for(int i = 0; i < Numbers.Length; i++)
            {
                if((i % 10) == 0)
                {
                    display += "\n";
                }
                display += Numbers[i] + " ";
            }
            return display;
        }

        public static int[] getNumbers()
        {
            return Numbers;
        }
    }
}
