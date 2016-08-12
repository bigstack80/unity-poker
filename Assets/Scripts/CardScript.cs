using UnityEngine;
using System.Collections;
using System;

public class CardScript : MonoBehaviour, IComparable
{

    public GameObject dealer;
    public GameObject player1;
    public bool selected = false;
    private int owner;
    public Card card;

    // Use this for initialization
    void Start () {
        dealer = GameObject.Find("Dealer");
        player1 = GameObject.Find("Player1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (this.owner == 1 && selected == false)
        {
            var x = this.transform.position.x;
            var y = this.transform.position.y;
            var z = this.transform.position.z;
            this.transform.position = new Vector3(x, y, z + .02f);
            selected = true;
        }
        else if (this.owner == 1 && selected == true)
        {
            var x = this.transform.position.x;
            var y = this.transform.position.y;
            var z = this.transform.position.z;
            this.transform.position = new Vector3(x, y, z - .02f);
            selected = false;
        }
    }

    public void setOwner(int player)
    {
        this.owner = player;
    }

    public void setCard(Card card)
    {
        this.card = card;
    }

    // implement IComparable interface
    public int CompareTo(object obj)
    {
        if (obj is Card)
        {
            return this.card.value.CompareTo((obj as Card).value);  // compare user names
        }
        throw new ArgumentException("Object is not a Card");
    }
}
