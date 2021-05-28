using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    // When new game is pressed, isLoading is set to false, when loading a game load the player prefs
    public static bool isLoading = false;

    // When this button is pressed make a new game
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    // When this button is pressed load the current game
    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(1);
    }

    // When this button is pressed quit the game
    public void ExitGame()
    {
        Application.Quit();
    }
}
