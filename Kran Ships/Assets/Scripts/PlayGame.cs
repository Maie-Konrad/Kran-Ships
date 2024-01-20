using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public Animator transitionCrossF;
    [SerializeField] float transtionWait;
    public void Playgame()
    {
        StartCoroutine(Playgame(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator Playgame(int levelIndex)
    {
        
        transitionCrossF.SetTrigger("Start");

        yield return new WaitForSeconds(transtionWait);

        SceneManager.LoadScene(levelIndex);
    }   
    public void QuitGame()
    {
        Application.Quit();
    }
}
