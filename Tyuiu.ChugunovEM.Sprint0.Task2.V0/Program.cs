using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChugunovEM.Sprint0.Tusk2.V0.Lib;

namespace Tyuiu.ChugunovEM.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.ChugunovEM.Sprint0.Tusk2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Егор"));
            Console.ReadKey();
        }
    }
}
