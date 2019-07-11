using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformFall : MonoBehaviour {

    public float secToFall = 2;
    private Rigidbody rb;
    private Material plateformeColor;
    private Color initColor;
    private Vector3 initPos;


	void Start () {
        rb = this.GetComponent<Rigidbody>();
        initPos = transform.position;
        plateformeColor = GetComponent<Renderer>().material;
        initColor = GetComponent<Renderer>().material.color;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Found player");
            plateformeColor.color = Color.grey;
            StartCoroutine(FallDown());
        }

        if(other.gameObject.tag == "ZoneTrigSpawn")
        {
            plateformeColor.color = initColor;
            rb.isKinematic = true;
            transform.position = initPos;

        }
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(secToFall);
        rb.isKinematic = false;
    }

    void Update () {

	}
}
