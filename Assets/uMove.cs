using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uMove : MonoBehaviour {

    public float velocidad = 0;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(Input.GetAxis("Horizontal"),
                                          0,
                                          Input.GetAxis("Vertical")) * velocidad * Time.deltaTime;
    }
}
