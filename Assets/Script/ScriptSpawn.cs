///////// Script Spawn Player pour Udemy //////////////////
///////////////////////////////////////////////////////////
////////  Instructeur Parein Jean-philippe ////////////////
///////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {
    public AudioClip ouch;

   	void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name== "FPSController")
        {
            GetComponent<AudioSource>().PlayOneShot(ouch);
            other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
            
        }	
	}		
}
