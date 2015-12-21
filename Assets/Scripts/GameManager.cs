using UnityEngine;
using UnityEngine.Networking;
using System.Collections.Generic;

public class GameManager : NetworkBehaviour {

	public List<short> trianglesCId;
	public List<short> spheresCId;
	// Use this for initialization
	void Start () {
		trianglesCId = new List<short> ();
		spheresCId = new List<short> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
