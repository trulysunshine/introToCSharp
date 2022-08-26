using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequiredItems : MonoBehaviour
{
    // List of objects required
    public List<GameObject> required;

    // Object to disable when all required ojects are gathered
    public GameObject target;

    // Number of required objects obtained so far
    private int requiredCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;

        // is this on the list?
        bool isOnList = false;
        for(int i = 0; i < required.Count; i++)
        {
            isOnList = true;
            break;
        }

        // If so, increase our counter
        if(isOnList)
        {
            requiredCounter++;
        }

        // Have we met the appropriate count to deactivate the target
        if(requiredCounter == required.Count)
        {
            target.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
