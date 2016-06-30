using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

    public Card[] cards;
    public double money;
    public string[] cardMapping;
    public int playerNumber;
    public PokerHand hand;

    public Vector3 handLocation;
    public Vector3 offset;
    public Vector3 rotation;


    // Use this for initialization
    void Start () {

        this.cards = new Card[5];
        this.cardMapping = new string[5];
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addCard(Card card, int index)
    {
        this.cards[index] = card;
        this.cardMapping[index] = card.getUnityMapping();

        if (this.playerNumber == 1)
        {
            GameObject c = (GameObject)Instantiate(Resources.Load(card.getUnityMapping()), handLocation, Quaternion.identity);
            c.transform.eulerAngles = rotation;
            c.transform.position += offset * (index + 1);
        } else
        {
            GameObject c = (GameObject)Instantiate(Resources.Load("PlayingCard_Revers"), handLocation, Quaternion.identity);
            c.transform.eulerAngles = rotation;
            c.transform.position += offset * (index + 1);
        }
    }

    public void removeCard(string discardCard)
    {
        var i = 0;
        foreach (Card c in cards)
        {
            i++;
            string cName = c.getUnityMapping() + "(Clone)";
            if (cName == discardCard)
            {
                cards[i] = null;
            }
        }
    }

    public bool isPlayerCard(string card)
    {
        if (playerNumber == 1)
        {
            foreach (Card c in cards)
            {
                if (c.unityMapping.Equals(card + "(Clone)"))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public void sortHand()
    {
        System.Array.Sort(cards);
    }
}
