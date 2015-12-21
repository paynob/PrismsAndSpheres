using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Player : NetworkBehaviour {

	[SyncVar]
	public Color color;
	/*
	public virtual void OnSetLocalVisibility(bool vis)
	{
		//Renderer r = GetComponent ("Renderer") as Renderer;
		//r.enabled = vis;
	}*/
}
