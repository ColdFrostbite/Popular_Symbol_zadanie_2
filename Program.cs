using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popular
{
    class Program
    {
        static void Main(string[] args)
        {
            String Vstr;
            int iSl;          
            string Word;
            int N;//максимальное число повторений
            int Num; //номер самого популярного элемента
            string Znak;//значение популярного символа

            Num = 0;


            Console.Write("Введите любой текст: ");
            Vstr = Console.ReadLine();
            Word = Vstr;
            iSl = Vstr.Length;
            int[] Mass1 = new int[iSl];
            string[] Mass2 = new string[iSl];
         

            for (int i = 0; i < iSl; i++)
            {
               Mass2[i] = Word.Substring(i, 1);

                for(int k = i; k<iSl; k++)
                {
                    if (string.Equals(Mass2[i], Word.Substring(k, 1)))
                    {
                        Mass1[i]++;
                    }
                }
                 
            }
            N = Mass1[0];

            for (int i = 1; i < iSl; i++)
            {
                if (N < Mass1[i])
                {
                    N = Mass1[i];
                    Num = i;
                }

            }


            Znak = Mass2[Num];

            Console.WriteLine("Самый популярный символ: " + Znak);
            
            Console.ReadLine();
        }
    }
    
}
