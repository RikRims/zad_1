using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    internal class Program
    {

        //делает из списка строку с элементами через запятую
        private string JastDoIt(List<string> Dano)
        {
            string String = "";

            foreach (string element in Dano)
            {
                String += $"{element}, ";
            }
            int lenght = String.Length - 2;
            String = String.Remove(lenght);
            String += ".";

            return String;
        }

        static void Main(string[] args)
        {
            //Собственно список
            Program zad_1 = new Program();
            List<string> goroda = new List<string>() { "Москва", "Питер", "Новород" };

            //вызов функции
            string resalt = zad_1.JastDoIt(goroda);
            Console.WriteLine(resalt);

            Console.ReadLine();
        }
    }
}
