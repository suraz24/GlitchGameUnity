using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public float autoLoadNextLevel;

	// Use this for initialization
	void Start () {
        if (autoLoadNextLevel == 0){
            Debug.Log("Level auto load disabled");

        }
        else{
            Invoke("LoadNextLevel", autoLoadNextLevel);
        }
	
	}

    public void LoadLevel(string name) {
        SceneManager.LoadScene(name);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
