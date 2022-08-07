using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public void sceneload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        tutorialUI.number_of_keypressed = 0;
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
    public void sceneload2222()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
