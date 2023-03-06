using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            string[] card_pack = { };
            int new_value = 0;
            int new_suit = 0;
            string suit_name = "";
            string card_name = "";
            

            while (card_pack.Count() > 52)
            {
                Card new_card = new Card();
                new_value = new_card.Value;
                new_suit = new_card.Suit;

                if (new_suit == 1)
                {
                    suit_name = "Hearts";
                }
                else if (new_suit == 2)
                {
                    suit_name = "Spades";
                }
                else if (new_suit == 3)
                {
                    suit_name = "Diamonds";
                }
                else if (new_suit == 4)
                {
                    suit_name = "Clubs";
                }
                else
                {
                    Console.WriteLine("Suit error");
                }

                if (new_value == 1 || new_value >= 11)
                {
                    if (new_value == 1)
                    {
                        card_name = "Ace of " + suit_name;
                    }
                    else if (new_value == 11)
                    {
                        card_name = "Jack of " + suit_name;
                    }
                    else if (new_value == 12)
                    {
                        card_name = "Queen of " + suit_name;
                    }
                    else if (new_value == 13)
                    {
                        card_name = "King of " + suit_name;
                    }
                    else
                    {
                        Console.WriteLine("Card name error 1");
                    }
                }
                else if (new_value <= 1 && new_value >= 10)
                {
                    card_name = new_value.ToString() + " of " + suit_name;
                }
                else
                {
                    Console.WriteLine("Card name error 2");
                }
                
                if (card_pack.Contains(card_name) == true)
                {
                    break;
                }
                else if (card_pack.Contains(card_name) == false)
                {
                    card_pack.Append(card_name);
                }
                else
                {
                    Console.WriteLine("Card append error");
                }

            }

        }

        
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {

            }
=
        }
        public static Card deal()
        {
            //Deals one card
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
        
    }
}
