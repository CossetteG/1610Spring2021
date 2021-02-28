using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rigidbodyObj;
    public float speed = 10f;
    public float jumpForce = 5f;
    
    private Vector2 direction;
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        //Direction.x =(speed * moveHorizontal);
        //RigidbodyObj.addForce(Direction, ForceMode2D.force);
    }
}
