using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public void FinishLvl()
    {
        //Save current scene
        PlayerPrefs.SetInt("currentScene", SceneManager.GetActiveScene().buildIndex);

        //Load menu
        SceneManager.LoadScene(0);
    }
}