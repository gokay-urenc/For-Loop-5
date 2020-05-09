using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_For_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, hak = 5;
            for (int i = 1; i <= hak; i--)
            {
                if (hak >= 1 && hak <= 5)
                {
                    Console.Write("0 - 10 arasında bir sayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi >= 0 && sayi <= 10)
                    {
                        toplam += sayi;
                        Console.Write("\nToplam sayı: " + toplam + "\n\n");
                    }
                    else
                    {
                        hak--;
                        if (hak == 0)
                        {
                            hak = 0;
                            Console.Write("\nHakkınız kalmadı. Son toplam: " + toplam + "\n\nProgram kapanıyor...");
                        }
                        else
                        {
                            Console.Write("\nToplam değişmedi. İstenilen aralıkta bir sayı girmediniz. Kalan hakkınız: " + hak + "\n\n");
                        }
                    }
                }
            }
        }
    }
}