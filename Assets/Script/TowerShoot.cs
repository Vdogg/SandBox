using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TowerShoot : MonoBehaviour {

    public AudioClip soundShoot;
    public GameObject prefabProjectile;  //celui qu'on va faire apparaitre
    private GameObject projectil;       //stock celui q'on instancie
    public float shootRate = 2;
    public float nextShoot;
    public int speed = 3000;
    public ForceMode currentForce;
    public 

	// Use this for initialization
	void Start () {
        currentForce = ForceMode.Impulse;

    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time > nextShoot)
        {      
            nextShoot = Time.time + shootRate;
            projectil = Instantiate(prefabProjectile, transform.position, Quaternion.identity);
            GetComponent<AudioSource>().PlayOneShot(soundShoot);
            projectil.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward*speed),currentForce);
            Destroy(projectil, 3f);
        }
            
	}
}
