using UnityEngine;
using UnityEngine.Networking;

public class ExitObjective : NetworkBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Has ganado");
	}
}
