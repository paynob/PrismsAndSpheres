using UnityEngine;
using UnityEngine.Networking;

public class Control : NetworkBehaviour
{

	public float speed = 4;
	Rigidbody2D rb;
	public GameObject model;
	public Camera camera;

	//public Camera camera;
	[SyncVar]
	float angle;
	GameObject character;

	void Start (){
		rb = GetComponent ("Rigidbody2D") as Rigidbody2D;
		character = GameObject.Instantiate (model);
		character.transform.parent = transform;
		character.transform.position = transform.position;
		character.transform.rotation = Quaternion.Euler (0, 0, 90);
		if (isLocalPlayer )
			camera = GameObject.Instantiate (camera);
		//Camera.current.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 10);
	}
	void Update()
	{
		if (!isLocalPlayer)
		{
			// exit from update if this is not the local player
			return;
		}

		// handle player input for movement
		Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		if (move.x != 0 || move.y != 0) {
			int a, b;
			a = (int)(move.x != 0 ? (move.x > 0 ? 1 : -1) : 0);
			b = (int)(move.y != 0 ? (move.y > 0 ? 1 : -1) : 0);

			angle = Mathf.Acos ((a) / Mathf.Sqrt (((a * a) + (b * b)))) * 180 / Mathf.PI; //=ACOS(REDONDEAR(B6)/(REDONDEAR(B6)*REDONDEAR(B6)+REDONDEAR(C6)*REDONDEAR(C6))^(1/2))*180/PI();
			//angle +=90;
			//Debug.Log(angle);
			if (b < 0) {
				angle = 360 - angle;
			}


			move.x *= speed;
			move.y *= speed;
			rb.velocity = move;
			camera.transform.position = transform.position;
		} else {
			rb.angularVelocity = 0;
			//rb.velocity = Vector2.zero;
		}
		transform.rotation = Quaternion.Euler (0, 0, angle);

		//Debug.Log (rb.velocity);
	}		
}