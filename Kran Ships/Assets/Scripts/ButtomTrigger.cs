using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomTrigger : MonoBehaviour
{
    PlayGame game = new PlayGame();

    public void PlayStartButtom()
    {

        game.Playgame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
