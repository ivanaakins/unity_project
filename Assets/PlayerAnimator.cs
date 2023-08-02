using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
public Animator animator;

public SpriteRenderer spriteRenderer;

public float previousDirection;

public bool iswalking= false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float x  = Input.GetAxisRaw ("Horizontal");
        float y = Input.GetAxisRaw ("Vertical"); 
       if(x== 0 && y== 0) {iswalking = false;}
        else{iswalking = true;}

        animator. SetBool("iswalking", iswalking);

        float currentDirection = Mathf. Sign(x);

        if (currentDirection != previousDirection && x != 0)

        { previousDirection = currentDirection;
        
        //spriteRenderer.flipX = !spriteRenderer.flipX; 
        
        }

        if (x !=0 || y != 0){
         animator.SetFloat("horizontal", x);

         animator.SetFloat("Vertical", y);




        }
    }

public void DoAttack(){

animator.SetTrigger("attack");

}

}
