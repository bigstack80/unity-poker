using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Card : IComparable
{
    public Value value;
    public Suite suite;
    public String unityMapping;

    public Card(Value value, Suite suite)
    {
        this.value = value;
        this.suite = suite;

        setUnityMapping();
    }

    public void setUnityMapping()
    {
        if (this.value == Value.TWO)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_2Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_2Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_2Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_2Spades";
            }
        }
        else if (this.value == Value.THREE)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_3Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_3Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_3Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_3Spades";
            }

        }
        else if (this.value == Value.FOUR)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_4Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_4Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_4Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_4Spades";
            }
        }
        else if (this.value == Value.FIVE)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_5Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_5Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_5Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_5Spades";
            }
        }
        else if (this.value == Value.SIX)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_6Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_6Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_6Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_6Spades";
            }
        }
        else if (this.value == Value.SEVEN)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_7Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_7Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_7Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_7Spades";
            }
        }
        else if (this.value == Value.EIGHT)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_8Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_8Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_8Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_8Spades";
            }
        }
        else if (this.value == Value.NINE)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_9Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_9Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_9Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_9Spades";
            }
        }
        else if (this.value == Value.TEN)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_10Club";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_10Diamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_10Heart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_10Spades";
            }
        }
        else if (this.value == Value.JACK)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_JClub";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_JDiamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_JHeart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_JSpades";
            }
        }
        else if (this.value == Value.QUEEN)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_QClub";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_QDiamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_QHeart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_QSpades";
            }
        }
        else if (this.value == Value.KING)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_KClub";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_KDiamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_KHeart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_KSpades";
            }
        }
        else if (this.value == Value.ACE)
        {
            if (this.suite == Suite.CLUBS)
            {
                this.unityMapping = "PlayingCards_AClub";
            }
            else if (this.suite == Suite.DIAMONDS)
            {
                this.unityMapping = "PlayingCards_ADiamond";
            }
            else if (this.suite == Suite.HEARTS)
            {
                this.unityMapping = "PlayingCards_AHeart";
            }
            else if (this.suite == Suite.SPADES)
            {
                this.unityMapping = "PlayingCards_ASpades";
            }
        }
    }

    public String getUnityMapping()
    {
        return this.unityMapping;
    }

    // implement IComparable interface
    public int CompareTo(object obj)
    {
        if (obj is Card)
        {
            return this.value.CompareTo((obj as Card).value);  // compare user names
        }
        throw new ArgumentException("Object is not a Card");
    }

    public enum Value { TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE };
    public enum Suite { HEARTS, DIAMONDS, CLUBS, SPADES };
}

