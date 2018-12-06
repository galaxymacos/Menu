﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {
    public void Exit() {
#if UNITY_EDITOR    // indicate that this is a platform dependence application 
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }
}