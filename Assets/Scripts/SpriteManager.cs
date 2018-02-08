using System;
using UnityEngine;

public static class SpriteManager
{
    private static Sprite[] _list = Resources.LoadAll<Sprite>("Images");
   
    public static Sprite GetSprite(CardType type)
    {
        foreach (Sprite sprite in _list)
        {
            if (sprite.name == TypeToName(type))
                return sprite;
        }

        return null;
    }

    private static String TypeToName(CardType type)
    {
        switch (type)
        {
            case CardType.Guard:
                return "Guard";
            case CardType.Spy:
                return "Spy";
            case CardType.Baron:
                return "Baron";
            case CardType.Handmaiden:
                return "Handmaiden";
            case CardType.Prince:
                return "Prince";
            case CardType.King:
                return "King";
            case CardType.Countess:
                return "Countess";
            case CardType.Princess:
                return "Princess";
        }
        return null;
    }
}