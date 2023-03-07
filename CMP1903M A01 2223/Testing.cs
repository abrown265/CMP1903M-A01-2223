using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    //A class for testing all the different shuffle types and deals 1 card and 4 cards from each type of shuffle.
    class Testing
    {        
        public static void test()
        {
            Pack test_pack = new Pack();            
            String[] card_pack = Pack.Create_Pack();

            Console.WriteLine("Fisher-Yates shuffle test:");
            card_pack = Pack.shuffleCardPack(1, card_pack);
            Pack.deal(card_pack);
            Pack.dealCard(4, card_pack);

            Console.WriteLine("Riffle shuffle test:");
            card_pack = Pack.shuffleCardPack(2, card_pack);
            Pack.deal(card_pack);
            Pack.dealCard(4, card_pack);

            Console.WriteLine("No shuffle test:");
            card_pack = Pack.shuffleCardPack(3, card_pack);
            Pack.deal(card_pack);
            Pack.dealCard(4, card_pack);

        }
        
    }
}
