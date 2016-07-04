using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PokerHand
{
    public bool RYL_FLUSH;
    public bool STRAIGHT_FLUSH;
    public bool FOUR_A_KIND;
    public bool FULL_HOUSE;
    public bool FLUSH;
    public bool STRIAGHT;
    public bool THREE_A_KIND;
    public bool TWO_PAIR;
    public bool PAIR;
    public bool HIGH_CARD;
    public List<Card> highCard;
    public int strength;

    public PokerHand()
    {
        this.RYL_FLUSH = false;
        this.STRAIGHT_FLUSH = false;
        this.FOUR_A_KIND = false;
        this.FULL_HOUSE = false;
        this.FLUSH = false;
        this.STRIAGHT = false;
        this.THREE_A_KIND = false;
        this.TWO_PAIR = false;
        this.PAIR = false;
        this.HIGH_CARD = false;
        this.highCard = new List<Card>();
        this.strength = 0;
    }

    public void setPokerHand(Card[] cardArray)
    {
        List<Card> cards = new List<Card>();
        foreach (Card c in cardArray)
        {
            cards.Add(c);
        }
        if (isRoyal(cards)) return;
        if (isStraightFlush(cards)) return;
        if (isFourAKind(cards)) return;
        if (isFullHouse(cards)) return;
        if (isFlush(cards)) return;
        if (isStraight(cards)) return;
        if (isThreeAKind(cards)) return;
        if (isTwoPair(cards)) return;
        if (isPair(cards)) return;
        isHigh(cards);

    }

    public String printResult()
    {

        if (this.RYL_FLUSH)
        {
            return "Royal Flush";
        }
        else if (this.STRAIGHT_FLUSH)
        {
            return "Straight Flush";
        }
        else if (this.FOUR_A_KIND)
        {
            return "Four of a kind";
        }
        else if (this.FULL_HOUSE)
        {
            return "Full house";
        }
        else if (this.FLUSH)
        {
            return "Flush";
        }
        else if (this.STRIAGHT)
        {
            return "Straight";
        }
        else if (this.THREE_A_KIND)
        {
            return "Three of a kind";
        }
        else if (this.TWO_PAIR)
        {
            return "Two Pair";
        }
        else if (this.PAIR)
        {
            return "Pair";
        }
        else if (this.HIGH_CARD)
        {
            return "High card";
        }
        else
            return "error setting hand.";
    }

    private bool isRoyal(List<Card> cards)
    {

        this.highCard = new List<Card>();
        this.highCard.Add(cards.ElementAt(4));

        if (isFlush(cards) && isStraight(cards) && this.highCard.ElementAt(0).value == Card.Value.ACE)
        {
            this.RYL_FLUSH = true;
            this.strength = 9;
        }
        return this.RYL_FLUSH;
    }

    private bool isStraightFlush(List<Card> cards)
    {

        this.highCard = new List<Card>();
        this.highCard.Add(cards.ElementAt(4));
        if (isFlush(cards) && isStraight(cards))
        {
            this.STRAIGHT_FLUSH = true;
            this.strength = 8;
            return true;
        }
        return false;
    }

    private bool isFourAKind(List<Card> cards)
    {

        this.highCard = new List<Card>();
        int count;

        for (int i = 0; i < 5; i++)
        {
            count = 0;
            Card curentCard = cards.ElementAt(i);
            foreach (Card card in cards)
            {
                if (curentCard.value == card.value)
                    count++;

                if (count == 4)
                {
                    this.FOUR_A_KIND = true;
                    this.highCard.Add(card);
                    this.strength = 7;

                    // find the kicker card
                    foreach (Card c in cards)
                    {
                        if ((int)c.value != (int)highCard.ElementAt(0).value)
                            this.highCard.Add(c);
                    }
                    return true;
                }
            }
        }
        return false;
    }

    private bool isFullHouse(List<Card> cards)
    {

        this.highCard = new List<Card>();
        int count;
        Card match1;
        Card match2 = null;

        for (int i = 0; i < 5; i++)
        {
            count = 0;
            Card curentCard = cards.ElementAt(i);
            foreach (Card card in cards)
            {
                if (curentCard.value == card.value)
                    count++;

                // found three of a kind
                if (count == 3)
                {
                    match1 = card;

                    // find the second match for the full house
                    foreach (Card c2 in cards)
                    {
                        if (match1.value != c2.value)
                        {
                            match2 = c2;
                        }
                    }

                    if (match2 != null)
                    {
                        count = 0;
                        foreach (Card c3 in cards)
                        {
                            if (match2.value == c3.value)
                            {
                                count++;
                                if (count == 2)
                                {
                                    this.highCard.Add(match1);
                                    this.highCard.Add(match2);
                                    this.FULL_HOUSE = true;
                                    this.strength = 6;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
        }
        return false;
    }

    private bool isFlush(List<Card> cards)
    {

        // check to see what suite the players card is and see if all cards
        // share that suite.
        this.highCard = new List<Card>();
        int playerSuite;
        Card card = cards.ElementAt(0);
        playerSuite = (int)card.suite;

        foreach (Card c in cards)
        {
            if ((int)c.suite != playerSuite)
                return false;
        }

        for (int i = 4; i >= 0; i--)
        {
            this.highCard.Add(cards.ElementAt(i));
        }

        this.FLUSH = true;
        this.strength = 5;
        return true;
    }

    private bool isStraight(List<Card> cards)
    {

        this.highCard = new List<Card>();
        Card card1 = cards.ElementAt(0);
        Card card2 = cards.ElementAt(1);
        Card card3 = cards.ElementAt(2);
        Card card4 = cards.ElementAt(3);
        Card card5 = cards.ElementAt(4);

        // make sure the cards rank is in order
        if (((int)card3.value - (int)card4.value == -1) && ((int)card2.value - (int)card3.value == -1) && ((int)card1.value - (int)card2.value == -1))
        {
            if ((card4.value - card5.value == -1))
            {
                this.STRIAGHT = true;
                this.strength = 4;

                for (int i = 4; i >= 0; i--)
                {
                    this.highCard.Add(cards.ElementAt(i));
                }
            }

            else if ((int)card1.value == 2 && (int)card5.value == 14 /* ACE */)
            {
                this.STRIAGHT = true;
                this.strength = 4;

                for (int i = 4; i >= 0; i--)
                {
                    this.highCard.Add(cards.ElementAt(i));
                }
            }
            else
                return this.STRIAGHT;
        }
        return this.STRIAGHT;
    }

    private bool isThreeAKind(List<Card> cards)
    {

        this.highCard = new List<Card>();
        int count;

        for (int i = 0; i < 5; i++)
        {
            count = 0;
            Card curentCard = cards.ElementAt(i);
            foreach (Card card in cards)
            {
                if (curentCard.value == card.value)
                    count++;

                if (count == 3)
                {
                    this.highCard.Add(card);
                    this.THREE_A_KIND = true;
                    this.strength = 3;

                    // find the two kickers
                    for (int j = 4; j >= 0; j--)
                    {
                        if (cards.ElementAt(j).value != this.highCard.ElementAt(0).value)
                            this.highCard.Add(cards.ElementAt(j));
                    }
                }
            }

        }
        return this.THREE_A_KIND;
    }

    private bool isTwoPair(List<Card> cards)
    {

        this.highCard = new List<Card>();
        int count;
        Card match1 = null;

        for (int i = 0; i < 5; i++)
        {
            count = 0;
            Card curentCard = cards.ElementAt(i);

            foreach (Card card in cards)
            {
                if (curentCard.value == card.value)
                    count++;

                // found a pair
                if (count == 2)
                {
                    match1 = card;
                    break;
                }
            }

            if (match1 != null) break;
        }

        // found one match
        if (match1 != null)
        {
            for (int i = 0; i < 5; i++)
            {
                count = 0;
                Card curentCard = cards.ElementAt(i);

                if (curentCard.value != match1.value)
                {
                    foreach (Card card in cards)
                    {
                        if (curentCard.value == card.value)
                            count++;

                        // found second pair
                        if (count == 2)
                        {
                            this.highCard.Add(card);
                            this.highCard.Add(match1);
                            this.TWO_PAIR = true;
                            this.strength = 2;

                            // get the kicker card
                            for (int j = 4; j >= 0; j--)
                            {
                                if (cards.ElementAt(j).value != this.highCard.ElementAt(0).value
                                        && cards.ElementAt(j).value != this.highCard.ElementAt(1).value)
                                    this.highCard.Add(cards.ElementAt(j));
                            }
                        }
                    }
                }
            }
        }

        return this.TWO_PAIR;
    }

    private bool isPair(List<Card> cards)
    {

        this.highCard = new List<Card>();
        int count;

        for (int i = 0; i < 5; i++)
        {
            count = 0;
            Card curentCard = cards.ElementAt(i);
            foreach (Card card in cards)
            {
                if (curentCard.value == card.value)
                    count++;

                if (count == 2)
                {
                    this.PAIR = true;
                    this.highCard.Add(card);
                    this.strength = 1;

                    for (int j = 4; j >= 0; j--)
                    {
                        if (this.highCard.ElementAt(0).value != cards.ElementAt(j).value)
                            this.highCard.Add(cards.ElementAt(j));
                    }
                }
            }

        }
        return this.PAIR;
    }

    private void isHigh(List<Card> cards)
    {

        this.highCard = new List<Card>();
        for (int j = 4; j >= 0; j--)
        {
            this.highCard.Add(cards.ElementAt(j));
        }
        this.HIGH_CARD = true;
    }

    public List<Player> breakTie(List<Player> player)
    {
        int highestRank, playerRank;
        List<Player> winningPlayer = player;

        int bounds = player.ElementAt(0).hand.highCard.Count();

        for (int i = 0; i < bounds; i++)
        {
            List<Player> tmp = winningPlayer;
            highestRank = 0;

            // for each card find the highest
            foreach (Player p in tmp)
            {
                playerRank = (int)p.hand.highCard.ElementAt(i).value;

                // find the player with the highest ranking cards
                if (playerRank > highestRank)
                {
                    highestRank = playerRank;
                }
            }

            // create a new list of the winniest players
            winningPlayer = new List<Player>();
            foreach (Player p in tmp)
            {
                playerRank = (int)p.hand.highCard.ElementAt(i).value;

                // eliminate players with crappy cards
                if (playerRank >= highestRank)
                {
                    winningPlayer.Add(p);
                }
            }

            if (winningPlayer.Count() == 1)
                return winningPlayer;
        }
        return winningPlayer;
    }
}

