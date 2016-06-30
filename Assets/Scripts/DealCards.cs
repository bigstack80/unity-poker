using UnityEngine;

public class DealCards : MonoBehaviour {

    GameObject[] players;
    private Vector3 discardLocation;
    private Vector3 rotation;
    private GameObject discardImage;
    private bool discardFlag;

    // used to keep track of the current dealer.
    public int dealerNumber;
    // Used to keep track of what turn it is.
    public int turn;
    // used to keep track of whos turn it is.
    public int currentPlayerIndex;

    private Deck deck;

	// Use this for initialization
	void Start () {
        turn = 0;
        currentPlayerIndex = 1;
        dealerNumber = 0;
        discardFlag = false;
        discardLocation = new Vector3(.3f, .05f, 0);
        rotation = new Vector3(-90, 0, 0);
        players = GameObject.FindGameObjectsWithTag("Player");

        deck = new Deck();
	}
	
	// Update is called once per frame
	void Update () {


	}

    // Manager method used to set the over all flow of the match
    public void deal()
    {
        //for each player deal 5 cards
        foreach (GameObject player in players)
        {
            for (int i = 0; i < 5; i++)
            {
                Card card = deck.draw();
                player.GetComponent<PlayerScript>().addCard(card, i);
            }
        }

        setPokerHand();


        //discard();
    }

    public void draw(GameObject player, int i)
    {
        Card card = deck.draw();
        player.GetComponent<PlayerScript>().addCard(card, i);
    }

    public void playerDiscard()
    {
        GameObject player1 = GameObject.Find("Player1");
        Card[] cards = player1.GetComponent<PlayerScript>().cards;

        var i = 0;
        foreach (Card card in cards) {
            if (card != null)
            {
                GameObject cardGameObject = GameObject.Find(card.getUnityMapping() + "(Clone)");
                if (cardGameObject.GetComponent<CardScript>().selected)
                {
                    discardCard(cardGameObject);
                    draw(player1, i);
                }
                i++;
            }
        }
        nextTurn();
    }

    public void discardCard(GameObject card)
    {
        card.transform.position = discardLocation;
        card.transform.eulerAngles = rotation;
        discardLocation.y += .0001f;

        // show the discard image on the top of the deck
        if (!discardFlag)
        {
            discardImage = (GameObject)Instantiate(Resources.Load("TopOfDeck"), discardLocation, Quaternion.identity);
            discardImage.transform.eulerAngles = rotation;
            discardFlag = true;
        } else
        {
            GameObject.Find("TopOfDeck(Clone)").transform.position = discardLocation;
        }
    }

    private void setPokerHand()
    {
        GameObject currentPlayer = players[currentPlayerIndex];
        // could use this to control game play

        PokerHand pokerHand;
        PokerHand[] pokerHandList = new PokerHand[4];
        int i = 0;
        foreach (GameObject p in players)
        {
            var playerScript = p.GetComponent<PlayerScript>();
            playerScript.sortHand();

            pokerHand = new PokerHand();
            pokerHand.setPokerHand(playerScript.cards);
            playerScript.hand = pokerHand;
            pokerHandList[i] = pokerHand;
            i++;
        }
    }

    // this is called when the discard button is clicked.
    private void nextTurn()
    {
        // player one we wait for manual inputs
        if (currentPlayerIndex == 0)
        {
            return;
        }

        //each player has finished their second turn.
        if (turn == 1 && (currentPlayerIndex == dealerNumber))
        {
            return;
        }

        // the dealer is the last one to get a turn the first draw.
        else if (currentPlayerIndex == dealerNumber)
        {
            turn++;
        }

        // Increment the player turn.
        if (currentPlayerIndex == 3)
        {
            currentPlayerIndex = 0;
        }
        else
        {
            currentPlayerIndex++;
        }
    }
}
