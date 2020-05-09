using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /* For this script, I need to make scenes for each function, besides
     * the QuitGame(), that one is already implemented
     * 
     * Right now every function besides QuitGame() loads the
     * Combat Scene
     * - Brandon Hale
     */

    public void NewGame()
    {
	SceneManager.LoadScene("Combat"); // This will load the combat scene
	Debug.Log("NewGame()");
    }
    public void LoadGame()
    {
	SceneManager.LoadScene("Combat"); // This will load the combat scene
	Debug.Log("LoadGame()");
    }
    public void Settings()
    {
	SceneManager.LoadScene("Combat"); // This will load the combat scene
	Debug.Log("Settings()");
    }
    public void Credits()
    {
	SceneManager.LoadScene("Combat"); // This will load the combat scene
	Debug.Log("Credits()");
    }
    public void QuitGame()
    {
	Application.Quit(); // This will quit the game as an application
    }
}
