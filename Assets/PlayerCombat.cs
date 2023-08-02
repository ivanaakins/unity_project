using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{


    public Animator animator;
   
   public bool isOnCooldown = false;
   public float cooldownLength = 0.6f;
    // Update is called once per frame
    void Update()
    {
      if (Input. GetButtonDown("Fire1") && !isOnCooldown) {

        isOnCooldown = true; 

         Invoke("EndCooldown", cooldownLength);


        animator.SetTrigger("attack");

      }
      

      if (Input. GetButtonDown("Fire2") && !isOnCooldown) {

        isOnCooldown = true ;

        Invoke("EndCooldown", cooldownLength);

        animator.SetTrigger("stab");

      }
    }
void EndCooldown(){
isOnCooldown = false;


}

}
