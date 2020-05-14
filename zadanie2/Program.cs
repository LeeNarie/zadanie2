using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static string zamenaH(string str)
        {
            string nstr = str;
            int k = 0;
            int index = str.IndexOf('h');
            int Lindex = str.LastIndexOf('h');

            for (int i = 0; i<str.Length; i++)
            {

                if (str[i].Equals('h')) k++;
            }

            if (k > 2)
            {

                string firsth = nstr.Substring(0, index + 1);
                string lasth = nstr.Substring(Lindex, nstr.Length - Lindex);
                string h = nstr.Substring(index + 1, Lindex - index - 1);

                h = h.Replace('h', 'H');



                nstr = firsth + h + lasth;

            }

                return nstr;
            
        }

            static string translit(string str)
        {

            string nstr = "";
            str = str.ToLower();

            char[] mas1 = new char[33] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'Ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            string[] mas2 = new string[33] { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h", "ts", "ch", "sh", "sch", "''", "i", "'", "e", "yu", "ya" };

            for (int i = 0; i < str.Length; i++)
            {

                int k = 0;
                for (int j = 0; j < 33; j++)
                {

                    if (str[i].Equals(mas1[j]))
                    {
                        k++;
                    }

                }
                if (k > 0)
                {
                    for (int j = 0; j < 33; j++)
                    {
                        if (str[i].Equals(mas1[j]))
                        {
                            nstr += mas2[j];
                        }
                    }
                }
                else nstr += str[i];
           
            }

            return nstr;
        }

        static void secondf(string str)
        {
            string nstr = str;

            if (nstr.IndexOf('f') ==-1)
            {
                Console.WriteLine("-2");
            }
            else
            {
                int index = nstr.IndexOf('f');
                nstr = nstr.Remove(index, 1);

                if (nstr.IndexOf('f') == -1)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(nstr.IndexOf('f')+1);
                }
            }
        }

        static void Main(string[] args)
        {

            secondf("Hello!");
            secondf("You are beautiful!");
            secondf("fifty five");

            Console.WriteLine(translit("Привет, мир!"));
            Console.WriteLine(translit("Один Два Три Четыре Пять"));

            Console.WriteLine(zamenaH("haha"));
            Console.WriteLine(zamenaH("hhhhhhhh"));
            Console.WriteLine(zamenaH("dhfghhhhhhhhsdf"));

            Console.ReadKey();
        }
    }
}
