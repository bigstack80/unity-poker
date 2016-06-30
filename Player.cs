using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Player : MonoBehaviour
{
    private List<Card> cards;
    public PokerHand hand;
    public double money;

    // Use this for initialization
    void Start()
    {

        this.cards = new List<Card>();
        this.hand = new PokerHand();
        this.money = 25.0;

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void addCard(Card card)
    {
        this.cards.Add(card);
    }

    public void printHand()
    {

        Card card;

        this.sortHand();

        //System.out.println("Player " + this.number + " hand");
        for (int i = 0; i < this.cards.size(); i++)
        {
            card = this.cards.get(i);
            //System.out.println("(" + (i + 1) + ")" + card.value + " " + card.suite);
        }
    }

    public void sortHand()
    {
        Collections.sort(this.cards);
    }
}


