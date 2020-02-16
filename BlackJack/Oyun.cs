using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Oyun
    {
        Deste destemiz = new Deste();
       
        public void baslat()
        {
            destemiz.deste_olustur();
            destemiz.karıstır();
            
        }
        public void oyna()
        {
            int o1p = 0, o2p = 0, o3p = 0, o4p = 0;
            for (int i = 0; i < 4; i++)
            {
               
                Kart k1 = destemiz.kartcek();
                Console.WriteLine("{0}.Oyuncunun 1.Kartı: {1}-{2},puanı {3}", i+1, k1.kartTuru, k1.kartlar, k1.puan);
                Kart k2 = destemiz.kartcek();
                Console.WriteLine("{0}.Oyuncunun 2.Kartı: {1}-{2},puanı {3}", i+1, k2.kartTuru, k2.kartlar, k2.puan);
                Console.WriteLine();
                if (i ==0)
                {
                    o1p = k1.puan + k2.puan;
                }
                if (i == 1)
                {
                    o2p = k1.puan + k2.puan;
                }
                if (i == 2)
                {
                    o3p = k1.puan + k2.puan;
                }
                if (i == 3)
                {
                    o4p = k1.puan + k2.puan;
                }
            }
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("{0}.Oyuncu kart çekmek istiyor mu?",j+1);
                if (j == 0)
                {
                    Console.WriteLine("Puanınız:{0}",o1p);
                }
                if (j == 1)
                {
                    Console.WriteLine("Puanınız:{0}", o2p);
                }
                if (j == 2)
                {
                    Console.WriteLine("Puanınız:{0}", o3p);
                }
                if (j == 3)
                {
                    Console.WriteLine("Puanınız:{0}", o4p);
                }
                Console.WriteLine("1-EVET    2-HAYIR");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Kart k3 = destemiz.kartcek();
                    Console.WriteLine("\nÇekilen kart:{0}--{1},puan:{2}\n", k3.kartTuru, k3.kartlar, k3.puan);
                    j--;
                    if (j == -1)
                    {
                        o1p += k3.puan;
                        Console.WriteLine("Puanınız:{0}\n", o1p);
                    }
                    if (j == 0)
                    {
                        o2p += k3.puan;
                        Console.WriteLine("Puanınız:{0}\n", o2p);
                    }
                    if (j == 1)
                    {
                        o3p += k3.puan;
                        Console.WriteLine("Puanınız:{0}\n", o3p);
                    }
                    if (j == 2)
                    {
                        o4p += k3.puan;
                        Console.WriteLine("Puanınız:{0}\n", o4p);
                    }
                }
                else
                    Console.WriteLine("\n");
            }
            Console.WriteLine("Puanlar:\n Oyuncu1:{0} \n Oyuncu2:{1} \n Oyuncu3:{2} \n Oyuncu4:{3}\n\n", o1p, o2p, o3p, o4p);
            if(21-o1p<0||21-o2p<0|| 21 - o3p < 0 || 21 - o4p < 0)
            {
                if (21 - o1p < 0)
                {
                    o1p = 0;
                    Console.WriteLine("Oyuncu 1 21'i geçtiği için elendi!!!\n");
                }
                if (21 - o2p < 0)
                {
                    o2p = 0;
                    Console.WriteLine("Oyuncu 2 21'i geçtiği için elendi!!!\n");
                }
                if (21 - o3p < 0)
                {
                    o3p = 0;
                    Console.WriteLine("Oyuncu 3 21'i geçtiği için elendi!!!\n");
                }
                if (21 - o4p < 0)
                {
                    o4p = 0;
                    Console.WriteLine("Oyuncu 4 21'i geçtiği için elendi!!!\n");
                }
            }
            if (21 - o1p < 21 - o2p && 21 - o1p < 21 - o3p && 21 - o1p < 21 - o4p && o1p <= 21)
            {
                Console.WriteLine("Oyuncu 1 kazandı");
            }
            else if (21 - o2p < 21 - o1p && 21 - o2p < 21 - o3p && 21 - o2p < 21 - o4p && o2p <= 21)
            {

                Console.WriteLine("Oyuncu 2 kazandı");

            }
            else if (21 - o3p < 21 - o2p && 21 - o3p < 21 - o1p && 21 - o3p < 21 - o4p && o3p <= 21)
            {

                Console.WriteLine("Oyuncu 3 kazandı");

            }
            else if (21 - o4p < 21 - o2p && 21 - o4p < 21 - o3p && 21 - o4p < 21 - o1p && o4p <= 21)
            {

                Console.WriteLine("Oyuncu 4 kazandı");
            }
            else
                Console.WriteLine("Beraberlik sağlandı");
        }
    }
}
