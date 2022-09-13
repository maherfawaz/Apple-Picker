using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame() {
        SceneManager.LoadScene("_Scene_0");
    }
    public void QuitGame() {
        Application.Quit();
    }
}
