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

        }
        public static String[] Create_Pack()
            {
                int new_value = 0;
                int new_suit = 0;
                string suit_name = "";
                string card_name = "";
                string[] card_pack = { };

                while (card_pack.Count() < 52)
                {
                    Card new_card = new Card();
                    new_value = new_card.Value;
                    new_suit = new_card.Suit;
                    Console.WriteLine(new_suit);
                    Console.WriteLine(new_value);

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
                return card_pack;
            }

        
        public static String[] shuffleCardPack(int typeOfShuffle, String[] card_pack)
        {
            if (typeOfShuffle == 1)
            {
                for (int i = 0; i < 52; i++)
                {
                    Random num = new Random();
                    int j = num.Next(0, 52);
                    string temp_i = card_pack[i];
                    card_pack[i] = card_pack[j];
                    card_pack[j] = temp_i;

                }

                return card_pack;
            }
            else if (typeOfShuffle == 2)
            {
                String[] pack_i = { };
                String[] pack_j = { };

                for (int i = 0; i < 26; i++)
                {
                    pack_i.Append(card_pack[i]);
                }
                for (int j = 26; j < 52; j++)
                {
                    pack_j.Append(card_pack[j]);
                }

                for(int n = 0; n < 26; n++)
                {
                    string[] shuffled_pack = { };
                    shuffled_pack.Append(pack_i[n]);
                    shuffled_pack.Append(pack_j[n]);

                    card_pack = shuffled_pack;
                }

                return card_pack;
            }
            else if (typeOfShuffle == 3)
            {
                return card_pack;
            }
            else if (typeOfShuffle == 4)
            {
                Testing test_program = new Testing();
                //test_program.test;
                return null;
            }
            else
            {
                Console.WriteLine("Shuffle error");
                return card_pack;
            }
        }
        
        
        public static Card deal(string[] card_pack)
        {
            Console.WriteLine(card_pack[0]);
            return null;
        }
        public static List<Card> dealCard(int amount, string[] card_pack)
        {
            for (int i = 1; i < amount; i++)
            {
                Console.WriteLine(card_pack[i - 1]);
            }
            return null;
        }
        
    }
}
