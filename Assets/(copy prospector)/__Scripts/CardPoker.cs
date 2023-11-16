using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// An enum defines a variable type with a few prenamed values // a
public enum CardState
{
    drawpile,
    tableau,
    target,
    discard,
}
public class CardPoker : Card
{

    [Header("Set Dynamically: CardPoker")]
    public CardState state = CardState.drawpile;

    public List<CardPoker> hiddenBy = new List<CardPoker>();

    public int layoutID;


    public SlotDef slotDef;

    override public void OnMouseUpAsButton()
    {
        // Call the CardClicked method on the Prospector singleton
        Poker.S.CardClicked(this);

        // Also call the base class (Card.cs) version of this method
        base.OnMouseUpAsButton(); // a
    }
}

