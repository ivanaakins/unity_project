using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wintigger : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.name =="player") { 
        print(collider.name);
            collider.GetComponent<SpriteRenderer>().color = Color.red;
            }
        
    }
        
    }

