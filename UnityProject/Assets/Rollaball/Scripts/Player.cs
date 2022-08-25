using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody rbody;
    public float jumpAmount = 10;

    public TMP_Text tmpScoreText;

    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float forward = Input.GetAxisRaw("Vertical");
        float up = Input.GetAxisRaw("Jump");

        rbody.AddForce(horizontal, 0.0f, forward);

        if(Input.GetButtonDown("Boost"))
        {
            rbody.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }

        tmpScoreText.text = points.ToString();
    }
}
