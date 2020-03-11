using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    public bool mainMenuLoaded;
    public void LoadMainMenu() {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        mainMenuLoaded = true;
    }
    public void UnloadMainMenu() {
        SceneManager.UnloadSceneAsync("MainMenu");
        mainMenuLoaded = false;
    }
}
