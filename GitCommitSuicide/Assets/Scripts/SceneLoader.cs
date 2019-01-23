using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    enum Scenes { Start, Main, End };

    public void LoadStartScene()
    {
        SceneManager.LoadScene((int)Scenes.Start);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene((int)Scenes.Main);
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene((int)Scenes.End);
    }

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
