using UnityEngine;
using System.Collections;

public class MoveRoundPortal : MonoBehaviour {

	public GameObject portal;


	void Update () {
	
		transform.RotateAround(portal.transform.position, Vector3.down, Time.deltaTime * 8);
	}
}
