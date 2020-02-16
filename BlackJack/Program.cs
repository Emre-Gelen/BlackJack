using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Blackjack oyununda amaç 21 sayısına en yakın olmaktır.\nEğer 21'i geçerseniz oyundan elenirsiniz.\nOyun başında size iki kart verilir ve siz sıranız geldiğinde yeni bir kart seçebilirsiniz.\n\n ");
            Oyun oyun = new Oyun();
            oyun.baslat();
            oyun.oyna();
        }
    }
}
