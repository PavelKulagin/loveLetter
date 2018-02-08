using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DeckActions : MonoBehaviour, IPointerClickHandler {
	Deck _deck;
	public GameObject Card;
    
	private void Start()
	{
		_deck = new Deck();
		Deck.DeckDepleted += DrawEndOfDeck;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		CardType? card = _deck.GetCard();
		if (card != null) DrawCard((CardType)card);
	}

	private void DrawCard(CardType cardType)
	{
		GameObject newCard = Instantiate(Card);
		CardActions card = newCard.GetComponent<CardActions>();
		card.DrawCard(cardType, transform.parent, new Vector3(transform.position.x - 320, transform.position.y));
	}

	private void DrawEndOfDeck()
	{
		Destroy(gameObject.GetComponent<Image>());
	}
}