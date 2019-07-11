using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    public int levelToLoad;
    public AudioClip soundWin;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(LoadNextLevel());
        }
    }

    IEnumerator LoadNextLevel()
    {
        GetComponent<AudioSource>().PlayOneShot(soundWin);
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene(levelToLoad);
    }
}
