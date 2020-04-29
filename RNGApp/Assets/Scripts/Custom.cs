using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Custom : MonoBehaviour
{
  public InputField input;
  public InputField input2;
 
   public GameObject TextBox;
   
 
  public void Generate(){
    input = GameObject.Find("input").GetComponent<InputField>();
int Number= Random.Range(int.Parse(input.text), int.Parse(input2.text) + 1);
TextBox.GetComponent<Text>().text = "" + Number;


   }
}