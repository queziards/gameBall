using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telas : MonoBehaviour
{
   public Text pointsText;
   public void Setup(int score) {
    gameObject.SetActive(true);
    pointsText.text = score.ToString() + " POINTS";
   }
   public void RestartButton(){

   }

   public void ExitButton(){

   }
}
