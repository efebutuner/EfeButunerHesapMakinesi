using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeButunerHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1 = KullaniciGiris("1.sayıyı");
            double sayi2 = KullaniciGiris("2.sayıyı");
            double sonuc = 0;
            char islem = operasyon();
            sonuc = Hesaplama(sayi1, sayi2, sonuc, islem);
            Console.WriteLine("Sonuç: " + sonuc);
            Console.ReadLine();
        }

        static double Hesaplama(double sayi1, double sayi2, double sonuc, char islem)
        {
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;

                case '-':
                    sonuc = sayi1 - sayi2;
                    break;

                case '*':
                    sonuc = sayi1 * sayi2;
                    break;

                case '/':
                    sonuc = sayi1 / sayi2;
                    break;

                default:
                    Console.WriteLine("Aradığınız işlem bulunamadı.");
                    break;

            }

            return sonuc;
        }

        static double KullaniciGiris(string sayıNo)
        {
            Console.Write("Lütfen " + sayıNo + " giriniz : ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static char operasyon()
        {
            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz (+,-,*,/): ");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}
