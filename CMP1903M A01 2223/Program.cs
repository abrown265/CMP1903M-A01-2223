using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            int shuffle_type = 0;
            int deal_amount = 0;

            Console.WriteLine("What kind of shuffle would you like to do (enter number):\n1: Fisher-Yates Shuffle\n2: Riffle Shuffle\n3: No Shuffle\n4: Test everything\n");
            shuffle_type = int.Parse(Console.ReadLine());
            while (shuffle_type < 1 || shuffle_type > 4)
            {
                Console.WriteLine("Invalid entry, enter again.");
                Console.WriteLine("What kind of shuffle would you like to do (enter number):\n1: Fisher-Yates Shuffle\n2: Riffle Shuffle\n3: No Shuffle\n4: Test everything\n");
                shuffle_type = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("How many do you want to deal?(enter any number 1-52 if testing)\n");
            deal_amount = int.Parse(Console.ReadLine());
            while (deal_amount < 1 || deal_amount > 52)
            {
                Console.WriteLine("Invalid entry, enter again.");
                Console.WriteLine("How many do you want to deal?\n");
                deal_amount = int.Parse(Console.ReadLine());
            }

            Pack pack = new Pack();
            string[] card_pack = Pack.Create_Pack();
            
            card_pack = Pack.shuffleCardPack(shuffle_type, card_pack);

            
            if (deal_amount == 1)
            {              
                Pack.deal(card_pack);
            }
            else
            {
                Pack.dealCard(deal_amount, card_pack);
            }
            

            Console.ReadLine();
        }
    }
}
