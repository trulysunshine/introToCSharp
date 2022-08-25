using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("THE PICKUP WAS TRIGGERED");

        //did we collide with the player?
        Player player = null;
        if(other.TryGetComponent<Player>(out player))
        {
            // if so, give the player a point
            player.points = player.points + 1;
            // destroy the pickup obeject
            Destroy(gameObject);
        }
        //otherwise don't do anything
    }
}
