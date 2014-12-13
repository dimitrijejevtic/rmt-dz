using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void main(string[] args)
        {
            int temp = Convert.ToInt16(Console.ReadLine());
          // konverzija iz dekadnog u bilo koji
            Console.WriteLine(Convert.ToString(temp, 2));
          //  Console.WriteLine(oct2four((Convert.ToInt16(temp)), 4));

            Console.ReadKey();
        }
        // samo za hex --> dec
       static public int hexa2dec(String hex, int baza)
        {
            char[] separated = hex.ToCharArray();
            int result = 0; int j = 0;
           for(int i=separated.Length-1; i>=0;i--){
                if (separated[i] == 'a')
                {
                    result += 10 * (int)Math.Pow(baza, j);
                }
                else if (separated[i] == 'b')
                {
                    result += 11 * (int)Math.Pow(baza, j);
                }
                else if (separated[i] == 'c')
                {
                    result += 12 * (int)Math.Pow(baza, j);
                }
                else if (separated[i] == 'd')
                {
                    result += 13 * (int)Math.Pow(baza, j);
                }
                else if (separated[i] == 'e')
                {
                    result += 14 * (int)Math.Pow(baza, j);
                }
                else if (separated[i] == 'f')
                {
                    result += 15 * (int)Math.Pow(baza, j);
                }
                else
                {
                    result += Convert.ToInt16(separated[i]) * (int)Math.Pow(baza, j);
                }
                j++;
            }
            return result;
        }

        // metoda radi za bilo koji sistem osim za binarni i hex
       static public int oct2four(int oct, int baza)
       {
           int dec = 0;
           int j = 0;
           while (oct > 0)
           {
               dec += oct % 10 * ((int)Math.Pow(8, j));
               oct /= 10;
               j++;
           }
          Console.WriteLine(dec);
          int temp = dec;
          int zeros = 0;
          int result = 0;
          while (temp > 0)
          {
                  temp /= 10;
                  zeros++;
          }

          for (int i=0; i<=zeros ; i++)
          {
              result += (dec % baza) * (int)Math.Pow(10, i);
              dec /= baza;
          }
              return result;
       }
    }
}
