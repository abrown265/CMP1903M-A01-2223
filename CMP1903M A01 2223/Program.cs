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
            bool shuffle_cards;

            Console.WriteLine("What kind of shuffle would you like to do (enter number):\n1: Fisher-Yates Shuffle\n2: Riffle Shuffle\n3: No Shuffle\n");
            shuffle_type = int.Parse(Console.ReadLine());
            Console.WriteLine("How many do you want to deal?\n");
            deal_amount = int.Parse(Console.ReadLine());


            Pack.shuffleCardPack(shuffle_type);


            if (deal_amount == 1)
            {
                Pack.deal();
            }
            else
            {
                Pack.dealCard(deal_amount);
            }


            Console.ReadLine();
        }
    }
}
