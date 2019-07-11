using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bam : MonoBehaviour {

    private Vector3 spawnPoint;
    public AudioClip ouch;


	void Start () {
        Debug.Log("Hello, i'm a bullet !");
        spawnPoint = GameObject.Find("SpawnPoint").GetComponent<Transform>().position;

	}



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(ouch);
            other.transform.position = spawnPoint;
        }
    }
}
