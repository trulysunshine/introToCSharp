using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindHazard : BaseHazard
{
    public float windStrength = 1;

    private Player affectedPlayer;

    //NOTE: this should really be FixedUpdate . . .

    private void Update()
    {
        // TODO: we can probably save this in a variable for later
        // instead of getting it every update
        Rigidbody playerRbody = affectedPlayer.GetComponent<Rigidbody>();

        playerRbody.AddForce(0, 0, windStrength);
    }

    protected override void OnPlayerEnter(Player target)
    {
        affectedPlayer = target;
    }
    protected override void OnPlayerExit(Player target)
    {
        affectedPlayer = target;
    }
}
