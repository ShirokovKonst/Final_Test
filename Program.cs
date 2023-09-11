using System;

namespace C__Final_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int szRez = 0;
            int count = Prompt("Введите количество элементов массива: ");
            string[] arr = FillArray(count);
            string[] resArr = ResultArray(szRez, arr);
        

            int Prompt(string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }

            string PromptStr(string msg)
            {
                Console.WriteLine(msg);
                return Console.ReadLine();
            }

            string[] FillArray(int c)
            {
                string[] result = new string[c];
                for (int i = 0; i < c; i++)
                {
                    result[i] = PromptStr("Введите " + i + " элемент массива: ");
                    if (result[i].Length > 3) szRez++; 
                }
                return result;
            }

            string[] ResultArray(int c, string[] arr)
            {
                if (c == 0) return null;
                string[] result = new string[c];
                int j = 0;
                while (j < c)
                {
                    for (int i = 0; i<arr.Length; i++)
                    {
                        if(arr[i].Length < 3)
                        {   
                            result[j] = arr[i];
                            j++;
                        }
                    }
                }
                return result;
            }
        }

        





    }
}
