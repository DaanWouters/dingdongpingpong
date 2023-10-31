using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    public void SinglePlayer()
    {
        SceneManager.LoadScene(2); // shows the paddle of singleplayer in the mainmenu
    }
    public void MultiPlayer()
    {
        SceneManager.LoadScene(1); // shows the paddle of multiplayer
    }
    public void SonicMode()
    {
        SceneManager.LoadScene(3); // shows the paddle in sonidmode 
    }
}
