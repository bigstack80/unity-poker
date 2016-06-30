using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Player
{
    List<Card> cards;
    public int number;
    public PokerHand hand;
    public double money;

    public Player(int num)
    {
        this.cards = new List<Card>();
        this.number = num;
        this.hand = new PokerHand();
        this.money = 25.0;
    }

    internal void addCard(object p)
    {
        throw new NotImplementedException();
    }

    public void sortHand()
    {
        this.cards.Sort();
    }
}

