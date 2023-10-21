using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint3.Task3.V14.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint3.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                               *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #14                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Используя цикл foreach заменить буквы d  на ’ в строке: dgt ghedd bed      *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string value = "dgt ghedd bed";
            char replacebale = 'd';
            char replacement = '’';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Заменяемый символ = " + replacebale);
            Console.WriteLine("Символ, на который заменяют = " + replacement);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Получившаяся строка = " + ds.ReplaceCharInString(value, replacebale, replacement));
            Console.ReadKey();
        }
    }
}
