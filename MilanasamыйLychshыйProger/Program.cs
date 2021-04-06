using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MilanasamыйLychshыйProger
{
    class Program
    {
        static void ListWriter(List<string> value)
        {
            for (int i = 0; i < value.Count; i++)
            {
                Console.WriteLine($"Значение элемента массива по индексу {i} {value[i]}");     // [] обращение к элементу
            }
        }
       
        static void Main()
        {
            List<string> Otstoy = new List<string>();

            Metca:
            Console.WriteLine("Укажите желаемый размер массива");
            int ListSize;
            bool IsSizeCorrect = int.TryParse(Console.ReadLine(), out ListSize);
            if (!IsSizeCorrect || ListSize <= 0 || ListSize > 20)
            {
                Console.WriteLine("Вы ввели недопустимое значение)");
                goto Metca;
            }
            for (int i = 0; i < ListSize; i++)
            {
                Console.WriteLine($"ВВеди строку по индексу {i}");
                Otstoy.Add(Console.ReadLine());
            }
            ListWriter(Otstoy);
          

            Console.ReadKey();

        }
     }
}

