using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Card : IComparable
{
    public Value value;
    public Suite suite;

    public Card(Value value, Suite suite)
    {
        this.value = value;
        this.suite = suite;
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

