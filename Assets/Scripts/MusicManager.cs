using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip[] GameSounds;
    private AudioSource audioSource;

	void Awake () {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont destroy on load " + gameObject.name);
	}

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }
	
	void OnLevelWasLoaded (int level) {
        AudioClip thislevelmusic = GameSounds[SceneManager.GetActiveScene().buildIndex];
        if (thislevelmusic) {
            audioSource.clip = thislevelmusic;
            audioSource.volume = PlayerPrefsManager.GetMasterVolume();
            audioSource.Play();
        }
        
	}

    public void ChangeVolume(float vol)
    {
        audioSource.volume = vol;
    }
}
