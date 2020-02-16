using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deste
    {
        Kart [] kartlar = new Kart [52] ;
        List<string> tur = new List<string>() {"Maça", "Sinek","Karo","Kupa" };
        List<string> kartismi = new List<string>() { "A", "2", "3", "4","5","6","7","8","9","10","J","Q","K" };
        List<int> puan = new List<int>() { 1,2,3,4,5,6,7,8,9,10,10,10,10 };

        public void deste_olustur()
        {
            int s = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    kartlar[s] = new Kart();
                    kartlar[s].kartTuru = tur[i];
                    kartlar[s].kartlar = kartismi[j];
                    kartlar[s].puan = puan[j];
                    s++;
                }
            }       
        }
       
        public void karıstır()
        {
            Random rnd = new Random();
            for (int i = 0; i < 52; i++)
            {
                int tutulan = rnd.Next(0, 52);
                Kart gecici = kartlar[i];
                kartlar[i] = kartlar[tutulan];
                kartlar[tutulan] = gecici;
            }
        }
        int cekilenkartsys = 0;
        public Kart kartcek()
        {
            return kartlar[cekilenkartsys++];
        }
      
    }
}
