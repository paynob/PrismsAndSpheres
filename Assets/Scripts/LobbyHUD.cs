using UnityEngine;
using UnityEngine.Networking;

public class LobbyHUD : MonoBehaviour {


	public NetworkManager manager;
	[SerializeField] public bool showGUI = true;
	[SerializeField] public int offsetX;
	[SerializeField] public int offsetY;
	
	// Runtime variable
	bool showServer = false;
	
	void Awake()
	{
		manager = GetComponent<NetworkManager>();
	}

	void OnGUI(){
		offsetX = Screen.width / 20;
		offsetY = Screen.height / 10;

		if (GUI.Button (new Rect (offsetX, offsetY, (Screen.width-3 * offsetX)/2, Screen.height - 2 * offsetY), "UNIRSE A SALA")) {

		}
		if (GUI.Button (new Rect ((offsetX+Screen.width)/2, offsetY, (Screen.width-3 * offsetX)/2, Screen.height - 2 * offsetY), "OPONENTES ALEATORIOS")) {
			
		}

	}
}
