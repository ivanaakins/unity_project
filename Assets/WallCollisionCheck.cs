using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WallCollisionCheck : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D coll) 
   {print (coll.transform.name);
    ReloadScene ();

    
   }

   void ReloadScene( )
   { int buildID = SceneManager.GetActiveScene(). buildIndex; SceneManager.LoadScene(buildID);}
}
