using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")){
            rb.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        } if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0) {
            rb.AddForce(new Vector2(5f, 0f), ForceMode2D.Impulse);
        } 
        else if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) {
            rb.AddForce(new Vector2(-5f, 0f), ForceMode2D.Impulse);
        }
    }
}
