using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textArr = text.Split(',');
            int[] arr = new int[textArr.Length];
            for (int i = 0; i < textArr.Length; i++)
            {
                arr[i] = int.Parse(textArr[i]);
            }

            int zero = 0;
            int positive = 0;
            int negative = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    positive++;
                }
                else if(arr[i] == 0)
                {
                    zero++;
                }
                else
                {
                    negative++;
                }
            }
            Console.WriteLine("Положительных = " + positive + ", Отрицательных = " + negative + ", Нулевых = " + zero);
            int a;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if(arr[i] > arr[k])
                    {
                        a = arr[i];
                        arr[i] = arr[k];
                        arr[k] = a;
                    }
                }
            }

            string arrText = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arrText = arrText + arr[i].ToString() + ", ";
            }
            
            Console.WriteLine(arrText);
            Console.Read();
        }
    }
}
