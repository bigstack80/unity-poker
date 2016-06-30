using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 *
 * @author Adam
 */
public class AiDecider
{

    // Finite state machine
    public List<Card> aiTurn(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();

        switch (pHand.strength)
        {
            // player has royal flush do nothing
            case 9:
                break;
            // player has straight flush do nothing
            case 8:
                break;
            // player has four of a kind do nothing
            case 7:
                break;
            // player has full house do nothing
            case 6:
                break;
            // player has flush do nothing
            case 5:
                break;
            // player has staight do nothing
            case 4:
                break;
            // player has three of a king discard non matching card
            case 3:
                discard = decideThree(pHand);
                break;
            // player has two pair discard non matching card
            case 2:
                discard = decideTwoPair(pHand);
                break;
            // player has pair must decide what to do
            case 1:
                discard = decidePair(pHand);
                break;
            // player has nothing to go with must decide
            case 0:
                discard = goForFlush(pHand);
                if (discard.Count > 0)
                    break;
                discard = goForStraight(pHand);
                if (discard.Count > 0)
                    break;
                discard = isAce(pHand);
                if (discard.Count > 0)
                    break;
                discard = discardLow(pHand);

                break;
            default:
                Console.Write("Error reading player hand");
                break;
        }
        return discard;
    }

    // player has three of a kind discard non matching card 
    private List<Card> decideThree(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();

        discard.Add(pHand.highCard.ElementAt(1));
        discard.Add(pHand.highCard.ElementAt(2));

        return discard;
    }

    // player has two pair discard non matching card
    private List<Card> decideTwoPair(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();

        discard.Add(pHand.highCard.ElementAt(2));

        return discard;
    }

    // player has a pair decide what to discard
    private List<Card> decidePair(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();

        discard.Add(pHand.highCard.ElementAt(1));
        discard.Add(pHand.highCard.ElementAt(2));
        discard.Add(pHand.highCard.ElementAt(3));

        return discard;
    }

    // player has nothing decide what to discard
    private List<Card> goForFlush(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();
        /** check for 4 of the same suite
         * 0 hearts
         * 1 diamonds
         * 2 clubs
         * 3 spades
         */
        int[] suite = new int[4];
        int matchFour = 4;
        foreach (Card c in pHand.highCard)
        {
            switch ((int)c.suite)
            {
                // hearts
                case 0:
                    suite[0] += 1;
                    if (suite[0] == 4)
                        matchFour = 0;
                    break;
                // diamonds
                case 1:
                    suite[1] += 1;
                    if (suite[1] == 4)
                        matchFour = 1;
                    break;
                // clubs
                case 2:
                    suite[2] += 1;
                    if (suite[2] == 4)
                        matchFour = 2;
                    break;
                // spades
                case 3:
                    suite[3] += 1;
                    if (suite[3] == 4)
                        matchFour = 3;
                    break;
            }
        }

        if (matchFour < 4)
        {
            foreach (Card c in pHand.highCard)
            {
                if ((int)c.suite != matchFour)
                    discard.Add(c);
            }
        }

        return discard;
    }

    private List<Card> goForStraight(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();

        // there are 10 possible straight combos
        for (int i = 0; i < 9; i++)
        {
            int count = 0;
            // five cards in each combo
            for (int j = i; j < i + 5; j++)
            {
                foreach (Card c in pHand.highCard)
                {
                    // handle ace being used as a low card striaght 
                    if (i == 0 && (int)c.value == 12)
                        count++;
                    if ((int)c.value == j)
                        count++;

                    if (count == 4)
                    {
                        // what card is not in our combo
                        for (int k = i; k < i + 5; k++)
                        {
                            foreach (Card d in pHand.highCard)
                            {
                                if ((int)d.value < i || (int)d.value > i + 5)
                                    discard.Add(d);
                            }
                        }
                    }
                }
            }
        }
        return discard;
    }

    private List<Card> isAce(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();

        if ((int)pHand.highCard.ElementAt(0).value == 12)
        {
            discard.Add(pHand.highCard.ElementAt(1));
            discard.Add(pHand.highCard.ElementAt(2));
            discard.Add(pHand.highCard.ElementAt(3));
            discard.Add(pHand.highCard.ElementAt(4));
        }
        return discard;
    }

    private List<Card> discardLow(PokerHand pHand)
    {
        List<Card> discard = new List<Card>();

        discard.Add(pHand.highCard.ElementAt(2));
        discard.Add(pHand.highCard.ElementAt(3));
        discard.Add(pHand.highCard.ElementAt(4));

        return discard;
    }


}

