using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : BasePickup
{
    public int pointValue = 10;

    // OnTriggerEnter

    protected override void ApplyPickup(Player target)
    {
        // base.ApplyPickup(target);
        target.points += pointValue;
    }
}
