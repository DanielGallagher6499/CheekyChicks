using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 20f;
    public float maxSpeed = 60f;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        PlayerCollision.setPlayerState(true);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;

        transform.Translate(new Vector3(hMovement, 0) * Time.deltaTime);
        transform.position += transform.forward * Time.deltaTime * movementSpeed;

        //Sppeds up our player the further they get
        if (movementSpeed < maxSpeed)
        {
            movementSpeed += .25f * Time.deltaTime; // Speeds player up as they get further
        }

        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

}
