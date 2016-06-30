using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Deck
{
    List<Card> card;

    public Deck()
    {
        card = new List<Card>();
        this.createDeck();
    }

    private void createDeck()
    {
        Array suites = Enum.GetValues(typeof(Card.Suite));
        Array values = Enum.GetValues(typeof(Card.Value));
        foreach (Card.Suite suite in suites)
        {
            foreach (Card.Value value in values)
            {
                this.card.Add(new Card(value, suite));
            }
        }
        this.shuffle();
    }

    // Shuffle the Card List
    public void shuffle()
    {
        if (this.card.Count >= 1)
            this.card = this.card.OrderBy(c => Guid.NewGuid()).ToList();
    }

    public void deal(Player[] players)
    {
        for (int i = 0; i < 5; i++)
        {
            foreach (Player player in players)
            {
                player.addCard(this.card.ElementAt(0));
                this.card.RemoveAt(0);
            }
        }
    }

    public Card draw()
    {
        Card drawCard;
        drawCard = this.card.ElementAt(0);
        this.card.RemoveAt(0);

        return drawCard;
    }
}


