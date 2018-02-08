using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardActions : MonoBehaviour {

	public void DrawCard(CardType cardType, Transform parent, Vector3 position)
	{
		GetComponent<Image>().sprite = SpriteManager.GetSprite(cardType);
		transform.position = position;
		transform.parent = parent;
	}
}