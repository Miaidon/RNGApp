using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Rand100 : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject TextBox;
   public int Number;

   public void Generate(){
Number= Random.Range(1, 101);
TextBox.GetComponent<Text>().text = "" + Number;
   }
}
