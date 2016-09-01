using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

public class DeckScript : MonoBehaviour {

    public List<GameObject> cards;
    public GameObject topOfDeck;
    Vector3 offset = new Vector3(0.0f, 0.01f, 0.0f);
    // Use this for initialization
    void Start() {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void createDeck()
    {
        Vector3 handLocation = this.transform.position;
        cards = new List<GameObject>();
        topOfDeck = (GameObject)Instantiate(Resources.Load("PlayingCard_Revers"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f));
        topOfDeck.transform.position += offset;
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_2Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TWO, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_3Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.THREE, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_4Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FOUR, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_5Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FIVE, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_6Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SIX, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_7Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SEVEN, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_8Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.EIGHT, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_9Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.NINE, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_10Club"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TEN, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_JClub"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.JACK, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_QClub"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.QUEEN, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_KClub"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.KING, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_AClub"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.ACE, Card.Suite.CLUBS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_2Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TWO, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_3Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.THREE, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_4Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FOUR, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_5Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FIVE, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_6Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SIX, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_7Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SEVEN, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_8Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.EIGHT, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_9Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.NINE, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_10Spades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TEN, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_JSpades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.JACK, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_QSpades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.QUEEN, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_KSpades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.KING, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_ASpades"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.ACE, Card.Suite.SPADES));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_2Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TWO, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_3Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.THREE, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_4Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FOUR, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_5Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FIVE, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_6Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SIX, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_7Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SEVEN, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_8Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.EIGHT, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_9Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.NINE, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_10Heart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TEN, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_JHeart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.JACK, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_QHeart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.QUEEN, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_KHeart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.KING, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_AHeart"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.ACE, Card.Suite.HEARTS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_2Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TWO, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_3Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.THREE, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_4Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FOUR, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_5Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.FIVE, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_6Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SIX, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_7Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.SEVEN, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_8Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.EIGHT, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_9Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.NINE, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_10Diamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.TEN, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_JDiamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.JACK, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_QDiamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.QUEEN, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_KDiamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.KING, Card.Suite.DIAMONDS));
        cards.Add((GameObject)Instantiate(Resources.Load("PlayingCards_ADiamond"), handLocation, Quaternion.Euler(270.0f, 0.0f, 0.0f)));
        cards.Last().GetComponent<CardScript>().setCard(new Card(Card.Value.ACE, Card.Suite.DIAMONDS));

    }

    // Shuffle the Card List
    public void shuffle()
    {
        if (this.cards.Count >= 1)
            this.cards = this.cards.OrderBy(c => Guid.NewGuid()).ToList();
    }

    public void deal(Player[] players)
    {
        for (int i = 0; i < 5; i++)
        {
            foreach (Player player in players)
            {
                player.addCard(this.cards.ElementAt(0));
                this.cards.RemoveAt(0);
            }
        }
    }

    public GameObject draw()
    {
        GameObject drawCard;
        drawCard = this.cards.ElementAt(0);
        this.cards.RemoveAt(0);

        return drawCard;
    }

    public void resetDeck()
    {
        foreach (GameObject card in this.cards)
        {
            Destroy(card);
        }
        this.cards = new List<GameObject>();
    }

    public List<GameObject> getCards()
    {
        return this.cards;
    }
}
