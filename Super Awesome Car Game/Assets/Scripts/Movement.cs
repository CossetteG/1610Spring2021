using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Physics2DModule;

public class Movement : MonoBehaviour
{
    
    
    public Rigidbody2D rigidbodyObj;
    public float speed = 3f;
    public float jumpForce = 3f;
    public Vector2 direction;
    
    void Start()
    {
        direction.x = Input.GetAxis("Horizontal");
        rigidbodyObj.AddForce(direction.x * speed);
        
        if (Input.GetButtonDown("Jump"))
        {
            direction.y = jumpForce;
            rigidbodyObj.AddForce(direction.y * jumpForce);
        }
    }
}
