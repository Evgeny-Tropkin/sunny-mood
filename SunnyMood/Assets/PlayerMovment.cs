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
        horizSpeed = 0.2f;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        if (System.Math.Abs(direction) > 0.1f)
        rb2D.AddForce(new Vector2(direction * horizSpeed, 0f), ForceMode2D.Impulse);
    }
}
