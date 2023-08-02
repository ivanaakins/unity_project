using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class coin : MonoBehaviour
{
   public int coins = 0;

   public TextMeshProUGUI coinText;
   void OnTriggerEnter2D(Collider2D coll) {
 if (coll.gameObject.tag == "coin") {

    coins++;

    coinText.text = "Coins: " + coins;

    Destroy(coll.gameObject);


 }

   }



}
