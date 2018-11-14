using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urbad : MonoBehaviour {
	public float x, y, z;
	private Vector3 oofergang; 

	void Start () {
		oofergang = new Vector3(x, y, z); 
		transform.Translate(oofergang);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
