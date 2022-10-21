using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chargement : MonoBehaviour {
    public string nomDeScene;

    public void nextScene() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nomDeScene);
    }
    public void quitter() {
        Application.Quit();
    }
}
