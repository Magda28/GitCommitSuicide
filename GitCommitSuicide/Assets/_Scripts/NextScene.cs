﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void LoadEndScene()
    {
        SceneManager.LoadScene(2);
    }

}