using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyManager : NetworkManager
{
	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		GameObject player = (GameObject)Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
		player.GetComponent<Player>().color = Color.red;
		NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
	}

	void AssignTeam ( short playerControllerId ){

	}
}
