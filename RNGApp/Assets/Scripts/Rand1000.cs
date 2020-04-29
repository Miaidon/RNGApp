using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Rand1000 : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject TextBox; // arvottu numero
   public int Number;

   public void Generate(){ //arpoo numeron annettujen arvojen välillä
Number= Random.Range(1, 1001);
TextBox.GetComponent<Text>().text = "" + Number;
   }
}
