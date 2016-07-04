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
        GameObject player1 = GameObject.Find("Player1");
        GameObject player2 = GameObject.Find("Player2");
        GameObject player3 = GameObject.Find("Player3");
        GameObject player4 = GameObject.Find("Player4");
        players = new GameObject[]{ player1, player2, player3, player4};

        deck = new Deck();
	}
	
	// Update is called once per frame
	void Update () {


	}

    // Manager method used to set the over all flow of the match
    public void deal()
    {
        //for each player deal 5 cards
        // TODO use the dealer index to start dealing to the next player.
        // TODO re write deal to deal one card at a time not 5, 5, 5, 5
        foreach (GameObject player in players)
        {
            for (int i = 0; i < 5; i++)
            {
                Card card = deck.draw();
                player.GetComponent<PlayerScript>().addCard(card, i);
            }
            setPokerHand(player);
        }

        // now that all players have been dealt to use the dealer and the current player index to 
        // keep track of turns.
        //playerDiscard();
    }

    // this method gets called when the player clicks the discard button.
    public void playerDiscard()
    {
        GameObject currentPlayer = players[0];
        Card[] cards = currentPlayer.GetComponent<PlayerScript>().cards;

        foreach (Card card in cards)
        {
            if (card != null)
            {
                GameObject cardGameObject = GameObject.Find(card.getUnityMapping() + "(Clone)");
                if (cardGameObject.GetComponent<CardScript>().selected)
                {
                    var discardLocation = cardGameObject.transform.position;
                    var discardIndex = currentPlayer.GetComponent<PlayerScript>().getCardIndex(card);
                    currentPlayer.GetComponent<PlayerScript>().replaceCard(deck.draw(), discardIndex, cardGameObject);
                    discardCard(cardGameObject);                    
                }
            }
        }
    }

    public void discardCard(GameObject card)
    {
        var newCardLocation = card.transform.position;
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

    private void setPokerHand(GameObject player)
    {
        PokerHand pokerHand;

        var playerScript = player.GetComponent<PlayerScript>();
        playerScript.sortHand();

        pokerHand = new PokerHand();
        pokerHand.setPokerHand(playerScript.cards);
        playerScript.hand = pokerHand;
        
        Debug.Log( "Player num: " +playerScript.playerNumber + " " + pokerHand.printResult());

        
    }
}
