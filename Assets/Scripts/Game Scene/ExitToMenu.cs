using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenu : MonoBehaviour
{
    // When button is pressed exit to menu
    public void ExitMenu()
    {
   
        SceneManager.LoadScene(0);

    }
}
