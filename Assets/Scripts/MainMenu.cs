﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    GameObject mainMenu;
    GameObject controlScheme;
    GameObject credits;

    void Start()
    {
        mainMenu = GameObject.Find("MainMenu");
        controlScheme = GameObject.Find("ControlScheme");
        mainMenu.SetActive(true);
        controlScheme.SetActive(false);
    }
    
    public void OpenScene(string name) {
        SceneManager.LoadScene(name);
    }

    public void ControlScheme()
    {
        mainMenu.SetActive(false);
        controlScheme.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenu.SetActive(true);
            controlScheme.SetActive(false);
        }
    }

}
