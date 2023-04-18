using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public bool isGrounded = false;
    public float movementMultiplier = 2;
    public float jumpPower = 10.0f;
    public float jumpMultiplier = 100.0f;
    public float gravityCompensation = 4;
    public Rigidbody2D rb;
    public SpriteRenderer spR;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spR = GetComponent<SpriteRenderer>();
        rb.gravityScale = gravityCompensation;
        spR.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        //left movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (isGrounded)
            {
                transform.Translate(-2 * Time.deltaTime * movementMultiplier, 0, 0);
                //Debug.Log("moving and grounded working");
            }
            else
            {
                transform.Translate(-2f * Time.deltaTime * movementMultiplier, 0, 0);
                //Debug.Log("moving and grounded not working");
            }
            spR.flipX = true;
        }
        //right movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (isGrounded)
            {
                transform.Translate(2 * Time.deltaTime * movementMultiplier, 0, 0);
            }
            else
            {
                transform.Translate(2f * Time.deltaTime * movementMultiplier, 0, 0);
            }
            spR.flipX = false;
        }


        //Jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpPower) * jumpMultiplier);
            //Debug.Log("jump");
        }

        if(this.transform.position.y <= 1.9)
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Sets isGrounded to true when it is touching something
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Sets isGrounded to false when not touching something
        isGrounded = false;
    }

}
