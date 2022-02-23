using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
        
        /*    // erkana girilen sayıya kadar olan tek sayılarını ekrana yazdır.
           Console.WriteLine("lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for(int i= 1; 1 <=sayac ; i++){
                
                // komutlar 
                if(i%2 == 1){
                    Console.WriteLine(i);
                }
            }*/

            // 1ile 100 arasındaki tek ve cift sayıların kendi içerisinde toplamlarını ekrana yazdır.

            int tekToplam= 0;
            int ciftToplam=0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1){
                    tekToplam += i; //TekToplam = tektoplam +i ; demek
                
                }
                else
                    ciftToplam += i; 
            }
            Console.WriteLine("Tek Toplam:"+tekToplam);
            Console.WriteLine("Cift Toplam :"+ciftToplam);

            // break, döngü icerisinde bir case baglı olarak loop dan cıkmak istiyorsak yani donguyu sonlandırmak istiyorsak kullanırız
            // continue,bir sarta bagla olarak atlamak istiyorsak kullanıyoruz.

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            } 
             for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            } 
        }
    }
}
