using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    private AsyncOperation async;

    public void BtnLoadScene() {
        if (async == null) {    // don't put two scenes simultaneously in async, or it will crash
            Scene currScene = SceneManager.GetActiveScene();
            async = SceneManager.LoadSceneAsync(currScene.buildIndex + 1);
            async.allowSceneActivation = true;    // after loading, should it immediately load the next scene? Or can I wait?
        }
    }

    public void BtnLoadScene(int i) {
        if (async == null) {    // don't put two scenes simultaneously in async, or it will crash
            async = SceneManager.LoadSceneAsync(i);
            async.allowSceneActivation = true;    // after loading, should it immediately load the next scene? Or can I wait?
        }
    }
    
    public void BtnLoadScene(string i) {    // find the scene by its name
        if (async == null) {    // don't put two scenes simultaneously in async, or it will crash
            async = SceneManager.LoadSceneAsync(i);
            async.allowSceneActivation = true;    // after loading, should it immediately load the next scene? Or can I wait?
        }
    }
    
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }
}