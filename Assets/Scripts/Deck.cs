using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Deck
{
    private List<CardType> _cards;
    public delegate void Deplete();
    public static event Deplete DeckDepleted;

    public Deck()
    {
        _cards = new List<CardType>();
        for (int i = 0; i < 5; i++)
        {
            _cards.Add(CardType.Guard);
        }
        _cards.Add(CardType.Spy);
        _cards.Add(CardType.Spy);
        _cards.Add(CardType.Baron);
        _cards.Add(CardType.Baron);
        _cards.Add(CardType.Handmaiden);
        _cards.Add(CardType.Handmaiden);
        _cards.Add(CardType.Prince);
        _cards.Add(CardType.Prince);
        _cards.Add(CardType.King);
        _cards.Add(CardType.Countess);
        _cards.Add(CardType.Princess);
    }

    public CardType? GetCard()
    {
        if (_cards.Count > 0)
        {
            int cardNumber = Random.Range(0, _cards.Count);
            CardType card = _cards[cardNumber];
            _cards.Remove(card);
            if (_cards.Count == 0 && DeckDepleted != null) DeckDepleted();
            return card;
        }
        return null;
    }
}
