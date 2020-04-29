using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Custom : MonoBehaviour
{
  public InputField input; //Teksti alue johon syötetään numero
  public InputField input2; //Teksti alue johon syötetään numero
 
   public GameObject TextBox;   // arvottu numero
   
 
  public void Generate(){   //arpoo numeron käyttäjän syöttämien arvojen välillä
    input = GameObject.Find("input").GetComponent<InputField>();
int Number= Random.Range(int.Parse(input.text), int.Parse(input2.text) + 1); // muuttaa string-tyypin int-tyypiksi
TextBox.GetComponent<Text>().text = "" + Number;


   }
}