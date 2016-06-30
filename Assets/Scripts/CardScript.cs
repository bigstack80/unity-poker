using UnityEngine;
using System.Collections;

public class CardScript : MonoBehaviour {

    public GameObject dealer;
    public GameObject player1;
    public bool selected = false; 

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
        foreach (Card c in player1.GetComponent<PlayerScript>().cards)
        {
            string cName = c.getUnityMapping() + "(Clone)";
            if (cName == gameObject.name && selected == false)
            {
                var x = this.transform.position.x;
                var y = this.transform.position.y;
                var z = this.transform.position.z;
                this.transform.position = new Vector3(x, y, z + .02f);
                selected = true;
            }
            else if (cName == gameObject.name && selected == true)
            {
                var x = this.transform.position.x;
                var y = this.transform.position.y;
                var z = this.transform.position.z;
                this.transform.position = new Vector3(x, y, z - .02f);
                selected = false;
            }
        }
    }
}
