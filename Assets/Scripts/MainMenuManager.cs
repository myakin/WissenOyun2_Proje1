using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {
    public Transform saveLoadPanel;
    public Button saveButton, loadButton, quitButton;

    private void Start() {
        saveButton.onClick.AddListener(Save);
        loadButton.onClick.AddListener(Load);
        quitButton.onClick.AddListener(Quit);
        //saveLoadPanel.gameObject.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameObject.FindGameObjectWithTag("SceneLoader").GetComponent<SceneLoader>().mainMenuLoaded) {
                Time.timeScale = 1;
                GameObject.FindGameObjectWithTag("SceneLoader").GetComponent<SceneLoader>().UnloadMainMenu();
            }
        }
    }

    private void Save() {
        GameObject.FindGameObjectWithTag("SaveLoadManager").GetComponent<SaveLoadManager>().Save();
    }
    private void Load() {
        GameObject.FindGameObjectWithTag("SaveLoadManager").GetComponent<SaveLoadManager>().Load();
    }

    private void Quit() {
        Application.Quit();
    }
}
