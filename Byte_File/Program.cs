using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный
//файл.

namespace Byte_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0-255");
            var userData = Convert.ToInt32(Console.ReadLine());
            if (userData>0 && userData < 256)
            {
                BinaryWriter userWrite = new BinaryWriter(output: File.OpenWrite("test.dat"));
                userWrite.Write(userData);
                userWrite.Close();
            }
            else
            {
                Console.WriteLine("Число вне диапозона 0-255");
                Console.ReadKey();
            }

        }
    }
}
