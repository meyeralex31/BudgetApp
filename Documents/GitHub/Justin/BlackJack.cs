using System;
using System.Collections;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace ConsoleApplication5
{
    public class BlackJack
    {
        int numPlayers;
        Deck d;
        //players 0 is com after that all users
        ArrayList<BlackJackPlayer> players;
        public BlackJack(int numPlayers)
        {
            this.numPlayers = numPlayers;
            d = new Deck();
            players = new ArrayList<BlackJackPlayer>();
            for (int i =0;i < this.numPlayers;i++)
            {
                players.Add(new BlackJackPlayer());
            }
        }
        public void round()
        {
            foreach (BlackJackPlayer b in players)
            {
                b.giveInitCards(d.deal(2));
            }
        }
    }
}
