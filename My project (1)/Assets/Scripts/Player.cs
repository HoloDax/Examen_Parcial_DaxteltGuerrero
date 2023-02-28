using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 8000f;
    
    public bool InAir = false;

    private Rigidbody2D Rigidbody2D;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }  
  
    void FixedUpdate()
    {
        Vector2 NoMovement = new Vector2(0f, 0f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        if (moveHorizontal > 0)
        {
            {
                Rigidbody2D.velocity = new Vector2(speed, Rigidbody2D.velocity.y);

            }
        }
        if (moveHorizontal < 0)
        {
            Rigidbody2D.velocity = new Vector2(-speed, Rigidbody2D.velocity.y);
        }
        
    }

}

