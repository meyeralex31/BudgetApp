using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    using System;

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Card : Object
    {
        //Ace is 0, Jack is 10, Queen is 11, King is 12
        private int value;
        public int Value { get { return value; }}
        //Heart is 0,Diamonds is 1,Spades is 2,Clubs is 3
        private int suit;
        public int Suit { get { return suit; }}
        public static readonly string[] faces = { "Heart", "Spades", "Diamonds", "Clubs" };
        public static readonly string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public override string ToString()
        {
            return values[value] + " of " + faces[suit];
        }
        public static void Main(string[] args)
        {
            //BlackJack bj = new BlackJack(2);
            //new Database();
            //Database.createEurcherDatabase();
            new Eurcher_Auto(0);
            Console.ReadLine();
        }
    }
}
