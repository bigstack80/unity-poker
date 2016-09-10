using UnityEngine;
using System.Collections;
using System;

public class CardScript : MonoBehaviour, IComparable
{

    public bool selected = false;
    public int owner;
    public Card card;
    Vector3 touchPosWorld;

    //Change me to change the touch phase used.
    TouchPhase touchPhase = TouchPhase.Ended;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        /*
        //We check if we have more than one touch happening.
        //We also check if the first touches phase is Ended (that the finger was lifted)
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase)
        {
            //We transform the touch position into word space from screen space and store it.
            touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

            //We now raycast with this information. If we have hit something we can process it.
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

            if (hitInformation.collider != null)
            {
                //We should have hit something with a 2D Physics collider!
                GameObject touchedObject = hitInformation.transform.gameObject;
                //touchedObject should be the object someone touched.
                Debug.Log("Touched " + touchedObject.transform.name);
            }
        }
        */
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
