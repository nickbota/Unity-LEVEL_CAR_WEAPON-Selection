using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public void Finish()
    {
        //Save new level
        PlayerPrefs.SetInt("currentScene", PlayerPrefs.GetInt("currentScene") + 1);

        //Load main menu
        SceneManager.LoadScene(0);
    }
}