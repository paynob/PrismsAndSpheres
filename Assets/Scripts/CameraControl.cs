using UnityEngine;
using UnityEngine.Networking;

public class CameraControl : NetworkBehaviour {


	void Start (){
		if(isLocalPlayer){
			enabled = true;
		}
		else{
			enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.identity;
	}

}
