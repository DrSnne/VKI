using System;
using System.Reflection.Metadata;

namespace VKI
{
    public class Program
    {
        public static void Main()
        {
            Boolean devam = true;
            do
            {
         
                Console.Write("kilonuz(kg): ");
                int kilo = Convert.ToInt32(Console.ReadLine());
                Console.Write("boyunuz(metre): ");
                decimal boy = Convert.ToDecimal(Console.ReadLine());

                decimal VKI = kilo / (boy * boy);
                Console.WriteLine(VKI);


                if (VKI < 18.5m)
                {
                    Console.WriteLine($"Hastanın; boyu: {boy}, kilosu: {kilo}, VKI indeksi: {VKI}, Teşhis: ZAYIF");
                }

                else if (VKI >= 18.5m && VKI < 25)
                {
                    Console.WriteLine($"Hastanın; boyu: {boy}, kilosu: {kilo}, VKI indeksi: {VKI}, Teşhis: İDEAL");
                }
                
                else if (VKI >= 25 && VKI < 30)
                {
                    Console.WriteLine($"Hastanın; boyu: {boy}, kilosu: {kilo}, VKI indeksi: {VKI}, Teşhis: HAFİF KİLOLU");
                }
                
                else if (VKI >= 30)
                {
                    Console.WriteLine($"Hastanın; boyu: {boy}, kilosu: {kilo}, VKI indeksi: {VKI}, Teşhis: OBEZ");
                }

                Boolean kontrol = false;

                do
                {
                    Console.Write("Yeni bir hesaplama yapmak istiyor musunuz?(E/H): ");
                    string yanit = Console.ReadLine();
                    kontrol= false;

                    if (yanit == "E" || yanit == "e")
                    {
                        devam = true;
                    }

                    else if (yanit == "H" || yanit == "h")
                    {
                        devam = false;
                        Console.WriteLine("Program isteğiniz üzere kapatılacaktır");
                        System.Threading.Thread.Sleep(2000);
                    }

                    else
                    {
                        Console.WriteLine("yanlış bir değer girdiniz için koruma amaçlı program kapatılacaktır!!!");
                        System.Threading.Thread.Sleep(2000);
                        kontrol= true;
                    }

                } while (kontrol);
                
            } while (devam);

         }
    }
}