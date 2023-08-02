using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{public float speed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { float x_input = Input.GetAxisRaw ("Horizontal");
        float y_input = Input.GetAxisRaw ("Vertical");

        Vector3 velocity = new Vector2 (x_input, y_input);

       transform.position = transform.position + velocity;
    }
}
