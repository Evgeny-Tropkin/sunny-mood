using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private float direction;
    private float horizSpeed;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        horizSpeed = 5.0f;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb2D.velocity = new Vector2(direction * horizSpeed, 0.0f);
    }
}
