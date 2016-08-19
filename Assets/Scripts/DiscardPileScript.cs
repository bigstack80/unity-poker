using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DiscardPileScript : MonoBehaviour {

    public List<GameObject> cards;
    private GameObject topOfDeck;
	// Use this for initialization
	void Start () {
        cards = new List<GameObject>();
        this.topOfDeck = new GameObject();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void add(GameObject card)
    {
        Vector3 discardLocation = this.transform.position;
        card.transform.position = this.transform.position;
        card.transform.rotation = this.transform.rotation;
        
        this.cards.Add(card);

        Destroy(this.topOfDeck);
        this.topOfDeck = (GameObject)Instantiate(Resources.Load("TopOfDeck"), discardLocation, Quaternion.identity);

        discardLocation.y += .0001f;
        topOfDeck.transform.position = discardLocation;
        topOfDeck.transform.rotation = this.transform.rotation;
    }

    public void reset()
    {
        foreach (GameObject g in cards)
        {
            Destroy(g);
        }
        this.cards = new List<GameObject>();
    }
}
