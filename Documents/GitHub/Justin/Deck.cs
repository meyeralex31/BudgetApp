using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace ConsoleApplication5
{
    using System;
    internal class Deck
    {
        public Card[] cards = new Cards[52];
        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0;j<13;j++)
                {
                    cards[j * (i + 1)] = new Card(j,i);
                    Console.WriteLine(cards[j*(i+1)]);
                }
            }
            Console.ReadLine();
        }
        
    }
}
