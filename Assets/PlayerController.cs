using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    bool playerIsGrounded = false;
    [SerializeField] float walkingSpeed;
    [SerializeField] float jumpStrength;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump")&&playerIsGrounded){
            direction = new Vector2(0f, 2f);
            rb.AddForce(direction*jumpStrength, ForceMode2D.Impulse);
            playerIsGrounded = false;
        } if (Input.GetButton("Horizontal")) {
            direction = new Vector2(1f, 0f);
            rb.AddForce(direction*walkingSpeed*Input.GetAxisRaw("Horizontal"), ForceMode2D.Impulse);
        } 
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        playerIsGrounded = true;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        playerIsGrounded = false;
    }
}
