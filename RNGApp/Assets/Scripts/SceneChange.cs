using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Menu()  //Vaihtaa scenen 
    {
        SceneManager.LoadScene("Menu");
    }

    public void NumeroScene10()
    {
        SceneManager.LoadScene("NumeroScene10");
    }

     public void NumeroScene100()
    {
        SceneManager.LoadScene("NumeroScene100");
    }

     public void NumeroScene1000()
    {
        SceneManager.LoadScene("NumeroScene1000");
    }

     public void NumeroSceneCustom()
    {
        SceneManager.LoadScene("NumeroSceneCustom");
    }

}
