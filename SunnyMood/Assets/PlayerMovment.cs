using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private float direction;
    private float horizSpeed;
    private Rigidbody2D rb2D;
    private float lastDirection;
    private SpriteRenderer sprtRend;
    private bool isOnThePlatform = true;

    // Start is called before the first frame update
    void Start()
    {
        horizSpeed = 5.0f;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        sprtRend = gameObject.GetComponent<SpriteRenderer>();
        lastDirection = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // if movement direction has been changed
        if (System.Math.Abs(lastDirection - direction) > 1.1)
        {
            Flip();
        }
        rb2D.velocity = new Vector2(direction * horizSpeed, 0.0f);
    }

    void Flip()
    {
        sprtRend.flipX = !sprtRend.flipX;
        lastDirection *= -1;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isOnThePlatform = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isOnThePlatform = false;
        }
    }
}
