using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

    public double money;
    public int playerNumber;
    public PokerHand hand;
    public GameObject[] unityCard;
    public Vector3 handLocation;
    public Vector3 offset;
    public Vector3 rotation;

    private Vector3 location1 = new Vector3(-0.1f, 0.037f, -0.45f);
    private Vector3 location2 = new Vector3(-0.02f, 0.037f, -0.45f);
    private Vector3 location3 = new Vector3(0.06f, 0.037f, -0.45f);
    private Vector3 location4 = new Vector3(0.14f, 0.037f, -0.45f);
    private Vector3 location5 = new Vector3(0.22f, 0.037f, -0.45f);


    // Use this for initialization
    void Start () {
        this.unityCard = new GameObject[5];
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addCard(GameObject c, int index)
    {

        if (this.playerNumber == 1)
        {
            c.transform.eulerAngles = rotation;
            c.transform.position = handLocation;
            c.transform.position += offset * (index + 1);
            this.unityCard[index] = c;
        } else
        {
            GameObject reverse = (GameObject)Instantiate(Resources.Load("PlayingCard_Revers"), handLocation, Quaternion.identity);
            reverse.transform.eulerAngles = rotation;
            reverse.transform.position += offset * (index + 1);
            this.unityCard[index] = c;
        }       
    }

    public void resetHand()
    {     
        this.hand = new PokerHand();
        this.unityCard = new GameObject[5];
    }

    public void replaceCard(GameObject c, int index, GameObject oldCard)
    {
        if (this.playerNumber == 1)
        {
            //GameObject c = (GameObject)Instantiate(Resources.Load(card.getUnityMapping()), handLocation, Quaternion.identity);
            c.transform.eulerAngles = rotation;
            c.transform.position = new Vector3(oldCard.transform.position.x, oldCard.transform.position.y, oldCard.transform.position.z - .02f);
            this.unityCard[index] = c;
        }
        else
        {
            //GameObject c = (GameObject)Instantiate(Resources.Load("PlayingCard_Revers"), handLocation, Quaternion.identity);
            c.transform.eulerAngles = rotation;
            c.transform.position += offset * (index + 1);
            this.unityCard[index] = c;
        }
    }

    public void removeCard(GameObject discardCard)
    {
        var i = 0;
        foreach (GameObject c in unityCard)
        {
            i++;
            if (c.Equals(discardCard))
            {
                unityCard[i] = null;
            }
        }
    }

    public int getCardIndex(GameObject card)
    {
        for (int i = 0; i < 5; i++)
        {
            if (unityCard[i].Equals(card))
            {
                return i;
            }
        }
        return -1;
    }

    public void sortHand()
    {
        Card[] cardList = new Card[5];
        GameObject[] tempList = new GameObject[5];

        int i = 0;
        foreach (GameObject card in unityCard)
        {
            cardList[i++] = card.GetComponent<CardScript>().card;
        }
        System.Array.Sort(cardList);

        for (i = 0; i < 5; i++)
        {
            foreach (GameObject card in unityCard)
            {
                if (card.GetComponent<CardScript>().card.Equals(cardList[i]))
                {
                    tempList[i] = card;
                }
            }
        }
        
        if (tempList[4] != null)
        {
            unityCard = tempList;
        } else
        {
            Debug.Log("Error sorting player Hand.");
        }

        if (playerNumber == 1)
        {
            resetLocation();
        }       
    }

    public void resetLocation()
    {
        this.unityCard[0].transform.position = location1;
        this.unityCard[1].transform.position = location2;
        this.unityCard[2].transform.position = location3;
        this.unityCard[3].transform.position = location4;
        this.unityCard[4].transform.position = location5;
    }

    public int getCardIndex(Card card)
    {
        int i = 0;
        foreach (GameObject c in unityCard)
        {
            if (c.GetComponent<CardScript>().card.Equals(card))
            {
                return i;
            }
            i++;
        }
        return -1;
    }

    public Card[] getCards()
    {
        Card[] cards = new Card[5];
        int i = 0;
        foreach (GameObject c in unityCard)
        {
            cards[i++] = c.GetComponent<CardScript>().card;
        }

        return cards;
    }

    public GameObject getCardAtIndex(int index)
    {
        return unityCard[index];
    }
}
