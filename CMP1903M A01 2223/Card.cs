using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        protected int _Value = 0;
        public int Value 
        { 
            get
            {
                return _Value;
            }
            set
            {
                Random num = new Random();

                _Value = num.Next(14);
            }
        }


        protected int _Suit = 0;
        public int Suit
        {
            get
            {
                return _Suit;
            }
            set
            {
                Random num = new Random();

                _Suit = num.Next(5);
            }
        }
    }
}
