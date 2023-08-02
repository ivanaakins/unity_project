using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsmovement : MonoBehaviour
{ 

    public float speed = 1f; 

    public Rigidbody2D rb;

    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        velocity.x = Input.GetAxisRaw ("Horizontal");
        velocity.y = Input.GetAxisRaw ("Vertical");
        
    }

    private void FixedUpdate()
        {rb.MovePosition (rb.position + velocity * speed * Time.fixedDeltaTime);
        
        }}

