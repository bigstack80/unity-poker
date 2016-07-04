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

    public void replaceCard(Card card, int index, GameObject oldCard)
    {
        this.cards[index] = card;
        this.cardMapping[index] = card.getUnityMapping();


        if (this.playerNumber == 1)
        {
            GameObject c = (GameObject)Instantiate(Resources.Load(card.getUnityMapping()), handLocation, Quaternion.identity);
            c.transform.eulerAngles = rotation;
            c.transform.position = new Vector3(oldCard.transform.position.x, oldCard.transform.position.y, oldCard.transform.position.z - .02f);
        }
        else
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

    public int getCardIndex(Card card)
    {
        for (int i = 0; i < 5; i++)
        {
            if (cards[i].Equals(card))
            {
                return i;
            }
        }
        return -1;
    }

    public void sortHand()
    {
        System.Array.Sort(cards);
        resetLocation();
    }

    public void resetLocation()
    {
        int i = 0;
        if (this.playerNumber == 1)
        {
            foreach (Card card in this.cards)
            {
                GameObject cardGameObject = GameObject.Find(card.getUnityMapping() + "(Clone)");
                cardGameObject.transform.position += offset * (i + 1);
            }
        }
    }
}
