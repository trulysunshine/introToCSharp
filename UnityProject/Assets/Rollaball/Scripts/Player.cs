using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody rbody;
    private MeshRenderer meshRend;
    private AudioSource audioSrc;

    public TMP_Text tmpScoreText;
   
    public List<AudioClip> jumpSounds = new List<AudioClip>();

    public List<Material> colorMaterials = new List<Material>();
    private int currentColorIndex = 0;

    public int points = 0;
    public float jumpAmount = 10;

    // time until jump again
    public float jumpCooldown = 5.0f;
    public float jumpTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        meshRend = GetComponent<MeshRenderer>();
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // color swaps
        // if you press the right bracket, next color
        if(Input.GetKeyDown(KeyCode.RightBracket))
        {
            currentColorIndex++;
            if(currentColorIndex >= colorMaterials.Count)
            {
                currentColorIndex = 0;
            }
            meshRend.sharedMaterial = colorMaterials[currentColorIndex];
        }
        // otherwise if you press left bracket, previous color
        else if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            currentColorIndex--;
            if(currentColorIndex < 0)
            {
                currentColorIndex = colorMaterials.Count - 1;
            }
            meshRend.sharedMaterial = colorMaterials[currentColorIndex];
        }

        // Movements
        float horizontal = Input.GetAxisRaw("Horizontal");
        float forward = Input.GetAxisRaw("Vertical");
        rbody.AddForce(horizontal, 0.0f, forward);

        // Jump function
        if(jumpTimer <= 0.0f && Input.GetButtonDown("Boost"))
        {
            rbody.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);

            jumpTimer = jumpCooldown;

            AudioClip selectedBoost = jumpSounds[Random.Range(0, jumpSounds.Count)];
            audioSrc.PlayOneShot(selectedBoost);
        }

        // Score UI
        tmpScoreText.text = points.ToString();
    }
}
