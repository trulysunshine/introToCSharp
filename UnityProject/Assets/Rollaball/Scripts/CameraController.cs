using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // What am I tracking?
    public Transform target;

    private Vector3 offset;

    // Follow the thing I'm tracking
    private void Start()
    {
        // calculate offset from target based on initial positions
        offset = transform.position - target.position;
    }

    private void Update()
    {
        // position camera at the location of the target + offset
        transform.position = target.position + offset;
    }
}
