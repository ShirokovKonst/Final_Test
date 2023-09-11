using System;

namespace C__Final_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Prompt("Введите количество элементов массива: ");
            string[] arr = FillArray(count);
        

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
                }
                return result;
            }
        }

        





    }
}
