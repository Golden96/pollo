using UnityEngine;
using System.Collections;

public class resetlevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D Obstaculo){
		Application.LoadLevel (Application.loadedLevel);
}
}